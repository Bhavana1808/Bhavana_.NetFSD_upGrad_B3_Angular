import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-demo',
  imports: [FormsModule],
  templateUrl: './demo.html',
  styleUrl: './demo.css',
})
export class DemoComponent {

  public count:number = 0;
  public uname:string  = "Narasimha";

  public button1ClickHandler():void
  {
     this.count++;
  }

  public button2ClickHandler():void
  {
     alert("Hi " + this.uname);
  }

}

