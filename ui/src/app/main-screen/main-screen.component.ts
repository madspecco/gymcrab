import { Component } from '@angular/core';
import {Router} from "@angular/router";

@Component({
  selector: 'app-main-screen',
  templateUrl: './main-screen.component.html',
  styleUrls: ['./main-screen.component.css']
})
export class MainScreenComponent {
  constructor(private router: Router) {}
  ngOnInit(): void {
  }


  goTo(destination: string) {
    this.router.navigate([`/${destination}`]);
  }

  // method and variable for the slider functionality
  showSlider: boolean = false;
  toggleSlider() {
    this.showSlider = !this.showSlider;
    console.log('Slider toggled: ', this.showSlider); // Use this log to troubleshoot
  }
}
