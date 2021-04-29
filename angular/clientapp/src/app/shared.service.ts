import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
// import { Guid } from "guid-typescript";

export interface AppUser{
  id: number,
  key: string,
  username: string,
  password: string,
  email: string,
  firstName: string,
  lastName: string,
  middleName: string,
  active: boolean,
  roles: Role[]
}

export interface Role{
  id: number,
  key: string,
  name: string,
  active: boolean
}

export interface AuthToken{
  id: number,
  firstName: string,
  lastName: string,
  username: string, 
  jwtToken: string,
  expiryDate: Date,
  refreshToken: string
}

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  readonly apiUrl = 'https://localhost:44345/api';
  private auth_token = '';
  // users: AppUser[] = [];
  
  constructor(private http: HttpClient) { 
    this.getToken();
  }

  getToken(): void{

  }
  getAllUser(): Observable<AppUser[]>{
    const headers = new Headers({
      'Content-Type': 'application/json',
      'Authorization': `Bearer ${this.auth_token}`
    });
    let url =`${this.apiUrl}/User/get-all`; 
    // this.users = this.http.get<AppUser[]>(url);
    return this.http.get<AppUser[]>(url); 
  }
}
