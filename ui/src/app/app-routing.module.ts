import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes} from "@angular/router";
import { StartingScreenComponent } from "./starting-screen/starting-screen.component";
import { SignupScreenComponent } from "./signup-screen/signup-screen.component";


const routes: Routes = [
  { path: '', component: StartingScreenComponent },
  { path: 'signup-screen', component: SignupScreenComponent },
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
