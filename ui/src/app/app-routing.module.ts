import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes} from "@angular/router";
import { StartingScreenComponent } from "./starting-screen/starting-screen.component";
import { SignupScreenComponent } from "./signup-screen/signup-screen.component";
import {GoalScreenComponent} from "./goal-screen/goal-screen.component";
import {ActivityScreenComponent} from "./activity-screen/activity-screen.component";
import {BiometricsScreenComponent} from "./biometrics-screen/biometrics-screen.component";
import {LoginScreenComponent} from "./login-screen/login-screen.component";
import {MainScreenComponent} from "./main-screen/main-screen.component";
import {WorkoutsScreenComponent} from "./workouts-screen/workouts-screen.component";


const routes: Routes = [
  { path: '', component: StartingScreenComponent },
  { path: 'goal-screen', component: GoalScreenComponent },
  { path: 'signup-screen', component: SignupScreenComponent },
  { path: 'activity-screen', component: ActivityScreenComponent },
  { path: 'biometrics-screen', component: BiometricsScreenComponent },
  { path: 'login-screen', component: LoginScreenComponent },
  { path: 'main-screen', component: MainScreenComponent },
  { path: 'workouts-screen', component: WorkoutsScreenComponent}
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
