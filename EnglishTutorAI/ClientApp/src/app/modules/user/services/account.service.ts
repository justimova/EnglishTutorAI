import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { ApplicationUser } from "../../auth/models/application-user";
import { Observable } from "rxjs";

@Injectable({
    providedIn: 'root'
})
export class AccountService {
    private apiUrl: string = "/api/account";

    constructor(private http: HttpClient) {}

    public getCurrentUser(): Observable<ApplicationUser> {
        return this.http.get<ApplicationUser>(`${this.apiUrl}/getCurrentUser`);
    }

    public saveCurrentUser(applicationUser: ApplicationUser): Observable<ApplicationUser> {
        return this.http.put<ApplicationUser>(`${this.apiUrl}`, applicationUser);
    }
}
