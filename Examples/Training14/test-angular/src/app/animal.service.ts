import { Injectable } from '@angular/core';

import { Animal } from './animal';
import { ANIMALS } from './mock-animals';

@Injectable()
export class AnimalService {
  getAnimals(): Animal[] {
    return ANIMALS;
  }

  getAnimal(name): Animal {
    return ANIMALS.filter(function (obj) {
        return obj.name === name;
      })[0];
  }
}