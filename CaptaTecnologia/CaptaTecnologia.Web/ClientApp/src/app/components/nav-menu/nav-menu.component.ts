import { Component } from '@angular/core';
import { Router } from '@angular/router';
import {GlobalConfig} from 'src/app/config';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  constructor(
    private router: Router,
    private config: GlobalConfig
    ) { }

  ngOnInit() {
    this.checkIfUserIsAuthenticated();
  }

  checkIfUserIsAuthenticated() {
    if(localStorage.getItem('token') != null)
      this.config.IS_AUTHENTICATED = true;
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  onLogout(){
    this.config.IS_AUTHENTICATED = false;
    localStorage.removeItem('token');
    this.router.navigate(['/login']);
  }
}
