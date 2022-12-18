"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var animal_1 = require("../aula07-classes/animal");
var animal_dao_1 = require("./animal-dao");
var dao = new animal_dao_1.AnimalDao();
var animal = new animal_1.Animal('Rex');
dao.insert(animal);
//# sourceMappingURL=run.js.map