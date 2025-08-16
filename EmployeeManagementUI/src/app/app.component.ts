import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Login } from './components/login/login';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Login],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class App {
  title = 'Employee Management System';
  data: any[] = [];
  date: Date = new Date();
  id: number = 0;

  // healthCheckService: Inject(HealthCheckService);

  // constructor() {
  //   this.healthCheckService.get().subscribe(data => {
  //     this.data = data;
  //     this.id = this.data[0].id;
  //     this.date = new Date(this.data[0].date);
  //   })
  // }
}
