import { Component, OnInit } from '@angular/core';
import { User } from '../../_models/user';
import { AltertifyService } from '../../_services/altertify.service';
import { UserService } from '../../_services/user.service';

@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css']
})
export class MemberListComponent implements OnInit {
  users: User[];
  constructor(
    private userService: UserService,
    private alertify: AltertifyService
  ) {}

  ngOnInit() {
    this.loadUsers();
  }
  loadUsers() {
    this.userService.getUsers().subscribe(
      (users: User[]) => {
        this.users = users;
      },
      error => {
        this.alertify.error(error);
      }
    );
  }
}
