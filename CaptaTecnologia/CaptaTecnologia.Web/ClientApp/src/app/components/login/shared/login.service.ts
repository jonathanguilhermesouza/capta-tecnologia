//packages
import { Injectable, Inject } from '@angular/core';
import { HttpClient } from "@angular/common/http";

//global variables
import { GlobalConfig } from 'src/app/config';

@Injectable({
  providedIn: 'root',
})
export class LoginService {
  private _baseUrl = '';

  constructor(
    private http: HttpClient,
    private config: GlobalConfig) {
    this._baseUrl = config.API_URL;
  }

  authenticate(formData) {
    return this.http.post(this._baseUrl + '/account/login', formData);
  }
}
