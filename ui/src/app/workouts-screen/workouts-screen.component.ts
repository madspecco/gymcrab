import { Component } from '@angular/core';
import {Router} from "@angular/router";

@Component({
  selector: 'app-workouts-screen',
  templateUrl: './workouts-screen.component.html',
  styleUrls: ['./workouts-screen.component.css']
})
export class WorkoutsScreenComponent {
  constructor(private router: Router) {}


  goTo(destination: string) {
    this.router.navigate([`/${destination}`]);
  }

  workoutsList: string[] = ['Leg Day Madness', 'Guns Day B-)', 'Rest Day(you did nothing)']; // Add your actual workouts here
}
