//packages
import { Component, OnInit } from '@angular/core';
import { Router } from "@angular/router";
import { ToastrService } from 'ngx-toastr';

//models
import { Candidate } from 'src/app/components/candidate/shared/candidate.model';

//services
import { CandidateService } from 'src/app/components/candidate/shared/candidate.service';

@Component({
  selector: 'candidate-list',
  templateUrl: './candidate-list.component.html',
  styleUrls: ['./candidate-list.component.css']
})
export class CandidateListComponent implements OnInit {

  constructor(private router: Router, private service: CandidateService,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }

  populateForm(emp: Candidate) {
    this.service.formData = Object.assign({}, emp);
  }

  onCreate() {
    this.router.navigate(['/candidate-create']);
  }

  onDelete(id: number) {
    if (confirm('Tem certeza que deseja remover?')) {
      this.service.deleteCandidate(id).subscribe(res => {
        this.service.refreshList();
        this.toastr.success('Removido com sucesso', 'Removido');
      });
    }
  }

  onEdit(candidate: Candidate): void {
    this.router.navigate(['/candidate-edit', candidate.id]);
  };

}
