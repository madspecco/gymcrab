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
}
