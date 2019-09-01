//packages
import { Component, OnInit, Inject } from '@angular/core';
import { ActivatedRoute } from "@angular/router";
import { Router } from "@angular/router";
import { FormGroup } from "@angular/forms";
import { ToastrService } from 'ngx-toastr';

//models
import { Gender } from '../../gender/shared/gender.model';
import { Candidate } from 'src/app/components/candidate/shared/candidate.model';

//services
import { CandidateService } from 'src/app/components/candidate/shared/candidate.service';
import { GenderService } from 'src/app/components/gender/shared/gender.service';

@Component({
  selector: 'candidate-edit',
  templateUrl: './candidate-edit.component.html',
  styleUrls: ['./candidate-edit.component.css']
})
export class CandidateEditComponent implements OnInit {

  candidate: Candidate;
  editForm: FormGroup;
  errors: string;
  listGenders: Gender[];

  constructor(
    private route: ActivatedRoute,
    private candidateService: CandidateService,
    private genderService: GenderService,
    private toastr: ToastrService,
    private router: Router) {
  }

  ngOnInit() {

    this.candidate = new Candidate();

    this.route.params.subscribe(params => {
      this.candidateService.editCandidate(params['id']).subscribe(res => {
        this.candidate = res;
      });
    });

    this.genderService.refreshList();
  }

  putCandidate() {
    console.log(this.candidate);
    this.candidateService.putCandidate(this.candidate).subscribe(
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
