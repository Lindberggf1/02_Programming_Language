"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var animal_1 = require("../aula07-classes/animal");
var cavalo_1 = require("../aula07-classes/cavalo");
var dao_1 = require("./dao");
var dao = new dao_1.Dao();
var animal = new animal_1.Animal('Rex');
var cavalo = new cavalo_1.Cavalo('Titã');
dao.insert(animal);
dao.insert(cavalo);
//# sourceMappingURL=run.js.map