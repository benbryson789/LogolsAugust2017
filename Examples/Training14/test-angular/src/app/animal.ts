import { Species } from './species';

export class Animal {
  id: number;
  name: string;
  summary: string;
  image: string;
  species: Species[];
  isselected: boolean;
  allowedit: boolean;
}