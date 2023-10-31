import {Component, OnInit} from '@angular/core';
import { Router } from "@angular/router";

@Component({
  selector: 'app-starting-screen',
  templateUrl: './starting-screen.component.html',
  styleUrls: ['./starting-screen.component.css']
})
export class StartingScreenComponent implements OnInit {
  constructor(private router: Router) {}
  ngOnInit(): void {
  }

  goToSignup() {
    this.router.navigate(['/signup-screen']);
  }

}
