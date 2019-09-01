//packages
import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";

//global variables
import { GlobalConfig } from 'src/app/config';

//models
import { Gender } from './gender.model';

@Injectable({
  providedIn: 'root',
})
export class GenderService {
  list: Gender[];
  private _baseUrl = '';

  constructor(
    private http: HttpClient,
    private config: GlobalConfig) {
    this._baseUrl = config.API_URL;
  }

  refreshList() {
    this.http.get(this._baseUrl + '/gender/getAllGender')
      .toPromise()
      .then(res => this.list = res as Gender[]);
  }
}
