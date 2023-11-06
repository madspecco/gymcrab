import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { StartingScreenComponent } from './starting-screen/starting-screen.component';
import { SignupScreenComponent } from './signup-screen/signup-screen.component';
import { AppRoutingModule } from './app-routing.module';
import { GoalScreenComponent } from './goal-screen/goal-screen.component';
import { ActivityScreenComponent } from './activity-screen/activity-screen.component';
import { BiometricsScreenComponent } from './biometrics-screen/biometrics-screen.component';

@NgModule({
  declarations: [
    AppComponent,
    StartingScreenComponent,
    SignupScreenComponent,
    GoalScreenComponent,
    ActivityScreenComponent,
    BiometricsScreenComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
