import { provideRouter, RouterModule, Routes } from '@angular/router';
import { Login } from './components/login/login';
import { RegisterForm } from './components/register-form/register-form';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { Dashboard } from './components/dashboard/dashboard';
import { AddressDetails } from './components/address-details/address-details';

const routes: Routes = [
  { path: '', redirectTo: '/login', pathMatch: 'full' },
  { path: 'Login', component: Login },
  { path: 'register-form', component: RegisterForm },
  { path: 'dashboard', component: Dashboard },
  { path: 'address-details', component: AddressDetails },
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes),
    ReactiveFormsModule
  ],
  exports: [RouterModule],
})

export class AppRoutingModule { }

export const appRoutingProviders = [
  provideRouter(routes)
];