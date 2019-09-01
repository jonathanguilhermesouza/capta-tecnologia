//packages
import { Injectable, Inject } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';

//global variables
import { GlobalConfig } from 'src/app/config';

//models
import { Candidate } from './candidate.model';

@Injectable({
  providedIn: 'root'
})
export class CandidateService {

  formData: Candidate;
  list: Candidate[];
  private _baseUrl = '';

  constructor(
    private http: HttpClient,
    private config: GlobalConfig) {
    this._baseUrl = config.API_URL;
  }

  editCandidate(id: string): Observable<Candidate> {
    return this.http.get<Candidate>(`${this._baseUrl}/candidate/getById/${id}`);
  }

  postCandidate(formData: Candidate): Observable<Candidate> {
    return this.http.post<Candidate>(this._baseUrl + '/candidate/postCandidate', formData);
  }

  putCandidate(formData: Candidate): Observable<Candidate> {
    return this.http.put<Candidate>(this._baseUrl + '/candidate/putCandidate/' + formData.id, formData);
  }

  refreshList(): void {
    this.http.get(this._baseUrl + '/candidate/getAllCandidate').toPromise().then(res => this.list = res as Candidate[]);
  }

  deleteCandidate(id: number) {
    return this.http.delete(this._baseUrl + '/candidate/deleteCandidate/' + id);
  }
}
