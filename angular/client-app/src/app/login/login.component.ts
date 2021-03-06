import { Component, OnInit } from '@angular/core';
import { from } from 'rxjs';
import { AuthService } from '../_services/auth.service';
import { TokenStorageService } from '../_services/token-storage.service';
import { UserService } from '../_services/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  form: any = {
    username: null,
    password: null
  };
  isLoggedIn = false;
  isLoginFailed = false;
  errorMessage = '';
  roles: string[] = [];

  constructor(private authService: AuthService, 
    private tokenStorage: TokenStorageService,
    private userService: UserService) { }

  ngOnInit(): void {
    if (this.tokenStorage.getToken()) {
      this.isLoggedIn = true;
      this.roles = this.tokenStorage.getUser().roles;
    }
  }

  onSubmit(): void {
    const { username, password } = this.form;

    this.authService.login(username, password).subscribe(
      data => {

        this.tokenStorage.saveToken(data.jwtToken);
        // this.tokenStorage.saveUser(data);
        this.saveLoggedUser(data.id);

        this.isLoginFailed = false;
        this.isLoggedIn = true;       

        this.roles = this.tokenStorage.getUser().roles;
        this.reloadPage();
      },
      err => {
        this.errorMessage = err.error.message;
        this.isLoginFailed = true;
      }
    );
  }

  saveLoggedUser(id:number): void{
    this.userService.getbyId(id).subscribe(
      data=>{
        if(data.user === null){
          this.tokenStorage.saveUser(data.user);
        }
    },
    err => {
      this.errorMessage = err.error.message;
      this.isLoginFailed = true;
    });
  }

  reloadPage(): void {
    window.location.reload();
  }
}