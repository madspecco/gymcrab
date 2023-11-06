import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes} from "@angular/router";
import { StartingScreenComponent } from "./starting-screen/starting-screen.component";
import { SignupScreenComponent } from "./signup-screen/signup-screen.component";
import {GoalScreenComponent} from "./goal-screen/goal-screen.component";
import {ActivityScreenComponent} from "./activity-screen/activity-screen.component";


const routes: Routes = [
  { path: '', component: StartingScreenComponent },
  { path: 'goal-screen', component: GoalScreenComponent },
  { path: 'signup-screen', component: SignupScreenComponent },
  { path: 'activity-screen', component: ActivityScreenComponent },
]
@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],

  exports: [RouterModule],
})
export class AppRoutingModule { }
