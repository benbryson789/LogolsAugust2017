import { Component } from '@angular/core';
import { Router } from '@angular/router';

import { Animal } from './animal';

import { AnimalService } from './animal.service';

@Component({
  selector: 'animals',
  templateUrl: './animals.component.html',
  styleUrls: ['./animals.component.css']
})
export class AnimalsComponent {
  constructor(private animalService: AnimalService,
              private router: Router) {}

  private animals: Animal[];

  getAnimals(): void {
    this.animals = this.animalService.getAnimals();
  }

  gotoAnimal(name): void {
    this.router.navigate(['/animal', name]);
  }

  clearSelectedAnimals() : void {
    for(let animal of this.animals) {
      animal.isselected = false;
    }
  }

  ngOnInit() {
    this.getAnimals();
    this.clearSelectedAnimals();
  }
}
