let BookStore = require('./02. Book Store_Ресурси');
let assert = require('chai').assert;

let bookStore;
beforeEach(() => {
    bookStore = new BookStore('Helikon')
})

describe('test BookStore', () => {

    it('test constructor', () => {
        assert.equal(bookStore.name, 'Helikon')
        assert.deepEqual(bookStore.books, []);
        assert.deepEqual(bookStore._workers, [])
    })
    it('test stockBooks', () => {

        const newBooks = ['Inferno-Dan Braun', 'Harry Potter-J.Rowling', 'Uncle Toms Cabin-Hariet Stow', 'The Jungle-Upton Sinclear']
        assert.deepEqual(bookStore.stockBooks(newBooks), [
            { title: 'Inferno', author: 'Dan Braun' },
            { title: 'Harry Potter', author: 'J.Rowling' },
            { title: 'Uncle Toms Cabin', author: 'Hariet Stow' },
            { title: 'The Jungle', author: 'Upton Sinclear' }
        ]
        );
    })
    it('test hire', () => {
        assert.deepEqual(bookStore.hire('Gosho', 'Manager'), 'Gosho started work at Helikon as Manager');
        assert.throw(() => bookStore.hire('Gosho', 'Manager'), 'This person is our employee')
    })
    it('test fire', () => {
        assert.throw(() => bookStore.fire('Gosho'), 'Gosho doesn\'t work here')
        bookStore.hire('Gosho', 'Manager');
        assert.deepEqual(bookStore.fire('Gosho'), 'Gosho is fired')
    })
    it('test sellBook', () => {
        bookStore.hire('Gosho', 'Manager');
        assert.throw(() => bookStore.sellBook('Peter Pan', 'Gosho'), 'This book is out of stock')
        bookStore.stockBooks(['Inferno-Dan Braun', 'Harry Potter-J.Rowling', 'Uncle Toms Cabin-Hariet Stow', 'The Jungle-Upton Sinclear']);
        assert.throw(() => bookStore.sellBook('Inferno', 'Pesho'), 'Pesho is not working here')
    })
    it('sellBook should increase count of seller', () => {
        bookStore.hire('Gosho', 'Manager');
        bookStore.stockBooks(['Inferno-Dan Braun', 'Harry Potter-J.Rowling']);
        bookStore.sellBook('Harry Potter', 'Gosho')
        assert.deepEqual(bookStore._workers[0], {
            name: 'Gosho',
            position: 'Manager',
            booksSold: 1
        })
        bookStore.books.pop('Harry Potter')
        assert.deepEqual(bookStore.books.length, 0);

    })
    it('test printWorkers', () => {
        bookStore.hire('Gosho', 'Manager');
        assert.equal(bookStore.printWorkers(), 'Name:Gosho Position:Manager BooksSold:0');
    })
    it('test printWorkers with selled book', () => {

        bookStore.hire('Pesho', 'Seller');
        bookStore.stockBooks(['Inferno-Dan Braun', 'Harry Potter-J.Rowling']);
        bookStore.sellBook('Harry Potter', 'Pesho')
        assert.equal(bookStore.printWorkers(), 'Name:Pesho Position:Seller BooksSold:1');
    })
})
