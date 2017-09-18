import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule }   from '@angular/router';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { HeaderComponent } from './header.component';
import { FooterComponent } from './footer.component';
import { AnimalComponent } from './animal.component';
import { AnimalsComponent } from './animals.component';

import { AnimalService } from './animal.service';

@NgModule({
  declarations: [
    AppComponent
    ,HeaderComponent
    ,FooterComponent
    ,AnimalComponent
    ,AnimalsComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot([
      {
        path: 'animal/:name',
        component: AnimalComponent
      },
      {
        path: 'animals',
        component: AnimalsComponent
      }
    ])
  ],
  providers: [AnimalService],
  bootstrap: [AppComponent]
})
export class AppModule { }
