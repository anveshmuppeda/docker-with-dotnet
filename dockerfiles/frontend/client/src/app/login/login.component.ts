import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { environment } from '../../environments/environment';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginData : any = { Username: '', Password: '' } ;
  errorMessage = '';
  constructor(private http: HttpClient , private router: Router) {}
  ngOnInit(): void {
  }

  login() {
    if (!this.loginData.Username || !this.loginData.Password) {
      this.errorMessage = 'Please enter both Username and Password.';
      return;
    }

    //this.http.post<any>('http://165.232.144.187:8081/api/Auth/login', this.loginData)
    const apiUrl = `${environment.apiUrl}/api/Auth/login`;
    this.http.post<any>(apiUrl, this.loginData)
    .subscribe(response => {
        // Handling  successful login response
        console.log('Login successful', response);
        // Redirect to dashboard
        this.router.navigate(['/home', this.loginData.Username]);
        
      }
    );
  }
}