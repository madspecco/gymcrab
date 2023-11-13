import { Component } from '@angular/core';
import {Router} from "@angular/router";

@Component({
  selector: 'app-main-screen',
  templateUrl: './main-screen.component.html',
  styleUrls: ['./main-screen.component.css']
})
export class MainScreenComponent {
  constructor(private router: Router) {}


  goTo(destination: string) {
    this.router.navigate([`/${destination}`]);
  }
}
