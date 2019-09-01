//packages
import { Component, OnInit, Input } from '@angular/core';
import { FormGroup } from "@angular/forms";
import { Router } from "@angular/router";
import { ToastrService } from 'ngx-toastr';

//models
import { Candidate } from 'src/app/components/candidate/shared/candidate.model';

//services
import { GenderService } from 'src/app/components/gender/shared/gender.service';
import { CandidateService } from 'src/app/components/candidate/shared/candidate.service';

@Component({
  selector: 'candidate-form',
  templateUrl: './candidate-form.component.html',
  styleUrls: ['./candidate-form.component.css']
})
export class CandidateFormComponent implements OnInit {

  @Input() candidate: Candidate;
  @Input() function: Function;
  @Input() descriptionAction: string;
  editForm: FormGroup;
  errors: string;

  constructor(
    private genderService: GenderService, 
    private candidateService: 
    CandidateService, 
    private router: Router,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.candidate = new Candidate();
    this.genderService.refreshList();

    //select default gender
    this.candidate.genderCodigo = "F";
  }
 
  save(): void {
    this.function();
  }
}
