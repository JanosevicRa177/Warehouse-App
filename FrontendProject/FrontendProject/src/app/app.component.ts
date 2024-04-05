import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
<<<<<<< HEAD
  
  constructor(private router: Router) { }

   navigateTo(url: string) {
    this.router.navigate([url]);
=======
  entities = ['worker', 'user'];
  
  handleOpenPage(entity: any){
>>>>>>> a238871 (Added commands, queries, handlers and controller templates/generators)
  }
}
