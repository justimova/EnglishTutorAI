import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';
import { Observable, map } from 'rxjs';
import { LoginModel } from '../models/login-model';
import { ApplicationUser } from '../models/application-user';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private apiUrl: string = "/api/auth";
  private jwtHelper = new JwtHelperService();
  currentUserEmail: string | null = null;

  constructor(private http: HttpClient) {}

  public login(credentials: LoginModel): Observable<any> {
    return this.http.post<any>(`${this.apiUrl}/login`, credentials, { responseType: 'json' })
      .pipe(map(user => {
        if (user) {
          this.currentUserEmail = user.email;
          this.saveToken(user.token);
        }
        return user;
      }));
  }

  public getCurrentUser(): Observable<ApplicationUser> {
    return this.http.get<ApplicationUser>(`${this.apiUrl}/getCurrentUser`);
  }

  public logout(): void {
    this.currentUserEmail = null;
    localStorage.removeItem('token');
  }

  public register(user: any): Observable<any> {
    return this.http.post(`${this.apiUrl}/register`, user);
  }

  public getToken(): string {
    return localStorage.getItem('token')!;
  }

  public isAuthenticated(): boolean {
    const token = this.getToken();
    return !!token && !this.jwtHelper.isTokenExpired(token);
  }

  public saveToken(token: string): void {
    localStorage.setItem('token', token);
  }

}
