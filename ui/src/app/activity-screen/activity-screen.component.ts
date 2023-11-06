import { Component } from '@angular/core';
import {Router} from "@angular/router";

@Component({
  selector: 'app-activity-screen',
  templateUrl: './activity-screen.component.html',
  styleUrls: ['./activity-screen.component.css']
})
export class ActivityScreenComponent {
  constructor(private router: Router) {}

  goTo(destination: string) {
    this.router.navigate([`/${destination}`]);
  }
}
