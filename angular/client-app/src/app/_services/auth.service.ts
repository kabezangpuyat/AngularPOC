import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

const AUTH_API = 'https://localhost:44345/api/Account/';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json',
                             'Access-Control-Allow-Origin': '*',
                             'Access-Control-Allow-Headers' : 'Origin, Content-Type, X-Auth-Token'})
};

@Injectable({
  providedIn: 'root'
})

export class AuthService {
  constructor(private http: HttpClient) { }

  login(username: string, password: string): Observable<any> {
    return this.http.post(AUTH_API + 'authenticate', {
      username,
      password
    }, httpOptions);
  }

  register(username: string, 
    password: string, 
    email: string,
    firstName: string,
    lastName: string,
    middleName: string): Observable<any> {
    return this.http.post(AUTH_API + 'register', {
      username,
      password,
      email,
      firstName,
      lastName,
      middleName
    }, httpOptions);
  }
}
