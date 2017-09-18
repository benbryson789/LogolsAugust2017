import { Component } from '@angular/core';

import { Animal } from './animal';

import { AnimalService } from './animal.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {
  constructor(private animalService: AnimalService) {}

  private animals: Animal[];

  getAnimals(): void {
    this.animals = this.animalService.getAnimals();
  }

  ngOnInit() {
    this.getAnimals();
  }
}
