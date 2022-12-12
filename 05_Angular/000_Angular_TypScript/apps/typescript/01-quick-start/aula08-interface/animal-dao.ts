import { DaoInterface } from "./dao.interface";
import { Animal } from "../aula07-classes/animal";

export class AnimalDao{

    tableName: string = '';

    insert(object: Animal): boolean{
        console.log('inserting');
        object.mover(50)
        return true;
    }

    update(object: Animal): boolean{
        return true;
    }

    delete(id: number): Animal{
        return null;
    }

    find(id: number): Animal{
        return null;
    }

    findAll(): [Animal]{
        return [new Animal('Rex')];
    }

}