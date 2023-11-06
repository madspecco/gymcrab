import { Component } from '@angular/core';
import {Router} from "@angular/router";

@Component({
  selector: 'app-signup-screen',
  templateUrl: './signup-screen.component.html',
  styleUrls: ['./signup-screen.component.css']
})
export class SignupScreenComponent {
  constructor(private router: Router) {}

  goTo(destination: string) {
    this.router.navigate([`/${destination}`]);
  }
}
