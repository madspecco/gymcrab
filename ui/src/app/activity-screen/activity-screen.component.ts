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

  // button select functionality
  changeClass(event: Event) {
    const clickedButton = event.target as HTMLButtonElement;

    // remove 'selected' class from all buttons
    const buttons = document.querySelectorAll('.selection-btns') as NodeListOf<HTMLButtonElement>;
    buttons.forEach((button) => {
      button.classList.remove('selected');
    });

    // add 'selected' class to the clicked button
    clickedButton.classList.add('selected');
  }
}
