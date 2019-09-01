//packages
import { Component, OnInit, Inject } from '@angular/core';
import { ActivatedRoute } from "@angular/router";
import { FormGroup } from "@angular/forms";
import { ToastrService } from 'ngx-toastr';
import { Router } from "@angular/router";

//models
import { Candidate } from 'src/app/components/candidate/shared/candidate.model';

//services
import { CandidateService } from 'src/app/components/candidate/shared/candidate.service';
import { GenderService } from 'src/app/components/gender/shared/gender.service';


@Component({
  selector: 'candidate-create',
  templateUrl: './candidate-create.component.html',
  styleUrls: ['./candidate-create.component.css']
})
export class CandidateCreateComponent implements OnInit {

  candidate: Candidate;
  editForm: FormGroup;
  errors: string;

  constructor(
    private route: ActivatedRoute,
    private candidateService: CandidateService,
    private genderService: GenderService,
    private toastr: ToastrService,
    private router: Router) { }

  ngOnInit() {
    this.candidate = new Candidate();
    this.genderService.refreshList();

    //select default gender
    this.candidate.genderCodigo = "F";
  }

  postCandidate() {
    this.candidateService.postCandidate(this.candidate).subscribe(
      candidate => {
        this.candidate = candidate;
        this.toastr.success('Atualizado com sucesso', 'Sucesso');
        this.router.navigate(['/candidate']);
      },
      err => {
        this.errors = 'Erro ao salvar';
        this.toastr.error('Atualizado com sucesso', 'Sucesso');
      }
    );
  }
}
