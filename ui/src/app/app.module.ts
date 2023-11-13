import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { StartingScreenComponent } from './starting-screen/starting-screen.component';
import { SignupScreenComponent } from './signup-screen/signup-screen.component';
import { AppRoutingModule } from './app-routing.module';
import { GoalScreenComponent } from './goal-screen/goal-screen.component';
import { ActivityScreenComponent } from './activity-screen/activity-screen.component';
import { BiometricsScreenComponent } from './biometrics-screen/biometrics-screen.component';
import { LoginScreenComponent } from './login-screen/login-screen.component';
import { MainScreenComponent } from './main-screen/main-screen.component';
import { WorkoutsScreenComponent } from './workouts-screen/workouts-screen.component';

@NgModule({
  declarations: [
    AppComponent,
    StartingScreenComponent,
    SignupScreenComponent,
    GoalScreenComponent,
    ActivityScreenComponent,
    BiometricsScreenComponent,
    LoginScreenComponent,
    MainScreenComponent,
    WorkoutsScreenComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
