import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})

export class SignupComponent implements OnInit {
  signupData : any = { Username: '', Password: '', confirmPassword: '' };
  errorMessage = '';

  constructor(private http: HttpClient, private router: Router) {}
  ngOnInit(): void {
  }

  signup() {
    if (!this.signupData.Username || !this.signupData.Password || !this.signupData.confirmPassword) {
      this.errorMessage = 'Please fill all fields.';
      return;
    }

    if (this.signupData.Password !== this.signupData.confirmPassword) {
      this.errorMessage = 'Passwords do not match.';
      return;
    }

    this.http.post('http://165.232.144.187:8081/api/Auth/signup', this.signupData)
.subscribe( response => {
          // Handle successful signup response
          console.log('Signup successful', response); 
          // Redirect to login page or perform any other action upon successful signup
          this.router.navigate(['/login']);
        })
  }
}
