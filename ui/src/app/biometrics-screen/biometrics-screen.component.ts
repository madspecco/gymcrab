import { Component } from '@angular/core';
import {Router} from "@angular/router";

@Component({
  selector: 'app-biometrics-screen',
  templateUrl: './biometrics-screen.component.html',
  styleUrls: ['./biometrics-screen.component.css']
})
export class BiometricsScreenComponent {
  constructor(private router: Router) {}

  goTo(destination: string) {
    this.router.navigate([`/${destination}`]);
  }

  ngOnInit() {
    // Set the "M" button as selected by default
    const maleButton = document.getElementById('male') as HTMLButtonElement;
    if (maleButton) {
      maleButton.classList.add('selected-sex');
    }
  }

  // button select functionality
  changeClass(event: Event) {
    const clickedButton = event.target as HTMLButtonElement;

    // remove 'selected' class from all buttons
    const buttons = document.querySelectorAll('.sex') as NodeListOf<HTMLButtonElement>;
    buttons.forEach((button) => {
      button.classList.remove('selected-sex');
    });

    // add 'selected' class to the clicked button
    clickedButton.classList.add('selected-sex');
  }
}
