//modules
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

//others
import { AuthInterceptor } from 'src/app/authentication/interceptor';
import { Activate } from './authentication/activate';

//services
import { LoginService } from 'src/app/components/login/shared/login.service';

//components
import { AppComponent } from './app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { HomeComponent } from './components/home/home.component';
import { CandidateComponent } from './components/candidate/candidate.component';
import { CandidateListComponent } from './components/candidate/candidate-list/candidate-list.component';
import { CandidateEditComponent } from './components/candidate/candidate-edit/candidate-edit.component';
import { CandidateCreateComponent } from './components/candidate/candidate-create/candidate-create.component';
import { LoginComponent } from './components/login/login.component';
import { LoginFormComponent } from './components/login/login-form/login-form.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CandidateComponent,
    CandidateListComponent,
    CandidateEditComponent,
    CandidateCreateComponent,
    LoginComponent,
    LoginFormComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    BrowserAnimationsModule,
    HttpClientModule,
    HttpModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, canActivate: [Activate]},
      { path: 'candidate', component: CandidateComponent, canActivate:[Activate]},
      { path: 'candidate-edit/:id', component: CandidateEditComponent, canActivate:[Activate]},
      { path: 'candidate-create', component: CandidateCreateComponent, canActivate:[Activate]},
      { path: 'login', component: LoginComponent}
    ]),
    ToastrModule.forRoot()
  ],
  providers: [LoginService, {
    provide: HTTP_INTERCEPTORS,
    useClass: AuthInterceptor,
    multi: true,
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
