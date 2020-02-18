class Library {

    constructor(libraryName) {
        this.libraryName = libraryName;
        this.subscribers = [];
        this.subscriptionTypes = {
            normal: this.libraryName.length,
            special: this.libraryName.length * 2,
            vip: Number.MAX_SAFE_INTEGER

        };
    }
    subscribe(name, type) {

        let subscriber;
        if (Object.keys(this.subscriptionTypes).includes(type)) {

            subscriber = this.subscribers.find(x => x.name === name)

            if (!subscriber) {
                subscriber = {
                    name,
                    type: type,
                    books: []
                }
                this.subscribers.push(subscriber);
            } else {
                subscriber.type = type;
            }
        } else {
            throw new Error(`The type ${type} is invalid`)
        }
        return subscriber;
    }
    unsubscribe(name) {

        let subscriber = this.subscribers.find(x => x.name === name);
        if (!subscriber) {
            throw new Error(`There is no such subscriber as ${name}`)
        }
        let index = this.subscribers.findIndex(x => x.name === name);
        this.subscribers.splice(index, 1);

        return this.subscribers;
    }
    receiveBook(subscriberName, bookTitle, bookAuthor) {

        let subscriber = this.subscribers.find(x => x.name === subscriberName);
        if (!subscriber) {
            throw new Error(`There is no such subscriber as ${subscriberName}`)
        }
        if (this.subscriptionTypes[subscriber.type] > subscriber.books.length) {
            let book = {
               title: bookTitle,
                author: bookAuthor
            }

            subscriber.books.push(book);

        } else {
            throw new Error(`You have reached your subscription limit ${this.subscriptionTypes[subscriber.type]}!`)
        }
        return subscriber;

    }
    showInfo (){

        let output = '';
        if (this.subscribers.length === 0) {
            output = `${libraryName} has no information about any subscribers`
        }
        for (const subscriber of this.subscribers) {
            output += `Subscriber: ${subscriber.name}, Type: ${subscriber.type}\n` +
            `Received books: ${subscriber.books.map(x=>`${x.title} by ${x.author}`).join(', ')}\n`
        }

        return output
    }
}
// let lib = new Library('Lib');

// console.log(lib.subscribe('Peter', 'normal'));
// console.log(lib.subscribe('John', 'special'));

// lib.receiveBook('John', 'A Song of Ice and Fire', 'George R. R. Martin');
// lib.receiveBook('Peter', 'Lord of the rings', 'J. R. R. Tolkien');
// lib.receiveBook('John', 'Harry Potter', 'J. K. Rowling');

// console.log(lib.showInfo());