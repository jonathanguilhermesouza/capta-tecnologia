

import { Injectable } from '@angular/core';
@Injectable({
    providedIn: 'root',
  })
export class GlobalConfig {
  readonly API_URL:string = 'https://localhost:44396/api';
  IS_AUTHENTICATED: boolean = false;
}