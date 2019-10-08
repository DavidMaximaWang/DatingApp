import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AltertifyService } from '../_services/altertify.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  model: any = {};
  constructor(public authService: AuthService, private alertify: AltertifyService) { }

  ngOnInit() {
  }
  login() {
    this.authService.login(this.model).subscribe(next => {
      this.alertify.success('Logged in succeffully');
    }, error => {
      this.alertify.error( error);
    });
    console.log(this.model);
  }
  loggedIn() {
    return this.authService.loggedIn();
  }
  logout() {
    localStorage.removeItem('token');
    this.alertify.message('logged out');
  }
}
