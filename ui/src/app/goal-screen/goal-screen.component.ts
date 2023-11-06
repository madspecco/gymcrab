import { Component } from '@angular/core';
import {Router} from "@angular/router";

@Component({
  selector: 'app-goal-screen',
  templateUrl: './goal-screen.component.html',
  styleUrls: ['./goal-screen.component.css']
})
export class GoalScreenComponent {
  constructor(private router: Router) {}

  goBack() {
    this.router.navigate(['/']);
  }

  goTo(destination: string) {
    this.router.navigate([`/${destination}`]);
  }
}
