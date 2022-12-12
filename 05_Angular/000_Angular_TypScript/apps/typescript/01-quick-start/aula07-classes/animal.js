"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Animal = void 0;
var Animal = /** @class */ (function () {
    function Animal(nome) {
        this.nome = nome;
    }
    Animal.prototype.mover = function (distanciaEmMetros) {
        console.log("".concat(this.nome, " moveu ").concat(distanciaEmMetros, "m."));
    };
    return Animal;
}());
exports.Animal = Animal;
//# sourceMappingURL=animal.js.map