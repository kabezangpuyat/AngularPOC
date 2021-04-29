import { Component, OnInit } from '@angular/core';
import { TokenStorageService } from 'src/app/_services/token-storage.service';
import { UserService } from 'src/app/_services/user.service';
// import { UserService } from '../_services/user.service';

@Component({
  selector: 'app-board-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {
  content?: string;

  constructor(private userService: UserService,
    private tokenService: TokenStorageService) { }

  ngOnInit(): void {
    let user = this.tokenService.getUser();
    this.content = `${user.lastName}, ${user.firstName}`;
    // this.userService.getAdminBoard().subscribe(
    //   data => {
    //     this.content = data;
    //   },
    //   err => {
    //     this.content = JSON.parse(err.error).message;
    //   }
    // );
  }
}