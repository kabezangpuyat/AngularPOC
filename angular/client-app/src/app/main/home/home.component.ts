import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/_services/user.service';
import { TokenStorageService } from 'src/app/_services/token-storage.service';
// import { UserService } from 'services/user.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  content?: string;

  constructor(private userService: UserService,
    private tokenService: TokenStorageService) { }

  ngOnInit(): void {
    let user = this.tokenService.getUser();
    this.content = `${user.lastName}, ${user.firstName}`;
    // let id = this.tokenService.getUser().id;
    // this.userService.getbyId(id).subscribe(
    //   data => {
    //     this.content = data.user;
    //   },
    //   err => {
    //     this.content = JSON.parse(err.error).message;
    //   }
    // );
  }
}