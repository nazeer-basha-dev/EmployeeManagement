import { Component } from '@angular/core';
import { ReactiveFormsModule, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { NgIf } from '@angular/common';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [ReactiveFormsModule, NgIf],
  templateUrl: './login.html',
  styleUrl: './login.css'
})

export class Login{
  loginForm: FormGroup;

  title = 'Employee Management System';
  data: any[] = [];
  date: Date = new Date();
  id: number = 0;
  isLoggedIn: boolean = false;

  constructor(private fb: FormBuilder, private router: Router) {
    this.loginForm = this.fb.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
    });
  }

  ngOnInit() {

  }
  onSubmit() {
    if (this.loginForm.valid) {
      const { username, password } = this.loginForm.value;
      console.log('Login attempt:', username, password);
      // You can add API call or navigation here
       this.router.navigate(['/register-form']);
    }
  }
}