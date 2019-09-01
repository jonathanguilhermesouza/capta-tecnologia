//packages
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { NgForm } from '@angular/forms';

//global variables
import { GlobalConfig } from 'src/app/config';

//services
import { LoginService } from 'src/app/components/login/shared/login.service';

@Component({
  selector: 'login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent implements OnInit {

  formModel = {
    userName: '',
    password: ''
  }

  constructor(
    private service: LoginService,
    private router: Router,
    private toastr: ToastrService,
    private config: GlobalConfig
  ) { }

  ngOnInit() {
    if (localStorage.getItem('token') != null)
      this.router.navigateByUrl('/');
  }

  onSubmit(form: NgForm) {
    this.service.authenticate(form.value).subscribe(
      (res: any) => {
        localStorage.setItem('token', res.token);
        this.config.IS_AUTHENTICATED = true;
        this.router.navigateByUrl('/');
      },
      err => {
        console.log(err.status )
        if (err.status == 0)
          this.toastr.warning('Talvez a API não esteja online', 'Conexão');
        else if (err.status == 400)
          this.toastr.warning('Usuário ou senha incorretos.', 'Autenticação');
        else
          this.toastr.error('Ocorreu algum erro desconhecido', 'Erro');
      }
    );
  }

}
