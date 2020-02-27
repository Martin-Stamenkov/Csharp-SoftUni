class Person {
    constructor(firstName,lastName){
        this.firstName = firstName;
        this.lastName = lastName;
    }
    get firstName(){
        return this._firstName;
    }
    set firstName(value){
        this._firstName = value
    }

    get lastName(){
        return this._lastName;
    }
    set lastName(value){
        this._lastName = value
    }

    get fullName(){
        return `${this.firstName} ${this.lastName}`
    }
    set fullName(value){
        let fullName = value.split(' ');

        if (fullName[0] !== undefined && fullName[1] !== undefined && fullName.length === 2) {
            this.firstName = fullName[0];
            this.lastName = fullName[1];
        }
    }
}
let person = new Person("Albert", "Simpson");
console.log(person.fullName);//Albert Simpson
person.firstName = "Simon";
console.log(person.fullName);//Simon Simpson
person.fullName = "Peter";
console.log(person.firstName) // Simon
console.log(person.lastName) // Simpson