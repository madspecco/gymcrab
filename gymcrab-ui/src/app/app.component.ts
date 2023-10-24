import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'gymcrab-ui';

  showMessageFlag = false;
  showMessageText = '';

  showMessage(message: string){
    this.showMessageText = message;
    this.showMessageFlag = true;

    // hide message after a time
    setTimeout(()=>{
      this.showMessageFlag = false;
    }, 3000);
  }
}
