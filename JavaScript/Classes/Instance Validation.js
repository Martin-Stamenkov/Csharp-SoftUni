class CheckingAccount {

    constructor(clientId, email, firstName, lastName) {
        this.clientId = clientId;
        this.email = email;
        this.firstName = firstName;
        this.lastName = lastName;
    }

    get clientId() {
        return this._clientId
    }
    set clientId(value) {
        let regex = /^[0-9]{6}$/
        if (!value.match(regex)) {
            throw new TypeError("Client ID must be a 6-digit number")
        }
        this._clientId = value;
    }

    get email() {
        return this._email;
    }
    set email(value) {
        let regex = /\S+@[a-zA-Z]+.[a-z]+/
        if (!value.match(regex)) {
            throw new TypeError("Invalid e-mail")
        }
        this._email = value;
    }
    get firstName() {
        return this._firstName;
    }
    set firstName(value) {
        let regexLength = /\S{3,20}/;
        let regexName = /[a-z]+/;
        if (!value.match(regexLength)) {

            throw new TypeError("First name must be between 3 and 20 characters long")
        }
        if (!value.match(regexName)) {
            throw new TypeError("First name must contain only Latin characters")
        }

        this._firstName = value;
    }


    get lastName() {
        return this._lastName
    }
    set lastName(value) {
        let regexLength = /\S{3,20}/;
        let regexName = /[a-z]+/;

        if (!value.match(regexLength)) {

            throw new TypeError("Last name must be between 3 and 20 characters long")
        }
        if (!value.match(regexName)) { 
            throw new TypeError("Last name must contain only Latin characters")
        }

        this._lastName = value;
    }

}
let acc = new CheckingAccount('131455', 'ivan@some.com', 'Ivan', 'P3trov')