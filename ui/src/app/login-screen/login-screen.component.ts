import { Component } from '@angular/core';
import {Router} from "@angular/router";

@Component({
  selector: 'app-login-screen',
  templateUrl: './login-screen.component.html',
  styleUrls: ['./login-screen.component.css']
})
export class LoginScreenComponent {
  constructor(private router: Router) {}

  goTo(destination: string) {
    this.router.navigate([`/${destination}`]);
  }
}
