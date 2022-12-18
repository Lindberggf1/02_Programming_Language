import { Animal } from "../aula07-classes/animal";
import { Cavalo } from "../aula07-classes/cavalo";
import { Dao } from "./dao";

let dao: Dao<Animal> = new Dao<Animal>();

let animal: Animal = new Animal('Rex');
let cavalo: Cavalo = new Cavalo('Titã');

dao.insert(animal);
dao.insert(cavalo);