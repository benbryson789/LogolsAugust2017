import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { Location } from '@angular/common';

import 'rxjs/add/operator/switchMap';

import { Animal } from './animal';
import { AnimalService } from './animal.service';

@Component({
  selector: 'animal',
  templateUrl: './animal.component.html',
  styleUrls: ['./animal.component.css']
})
export class AnimalComponent {
  constructor(private animalService: AnimalService
              ,private route: ActivatedRoute
              ,private location: Location
  ) { }

  private animal: Animal;
  private sub: any;

  getAnimal(name): void {
    this.animal = this.animalService.getAnimals().filter(function (obj) {
      return obj.name === name;
    })[0];
  }

  allowEdit(): void {
    this.animal.allowedit = true;
  }

  cancelEdit(): void {
    this.animal.allowedit = false;
  }

  ngOnInit(): void {
    this.sub = this.route.params.subscribe(params => {
       this.animal = this.animalService.getAnimal(params['name']);
       this.animal.isselected = true;
    });
  }
}
