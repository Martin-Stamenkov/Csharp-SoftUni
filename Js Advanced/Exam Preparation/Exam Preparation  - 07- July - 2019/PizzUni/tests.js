let PizzUni = require('./02. PizzUni_Ресурси');
let assert = require('chai').assert;

let pizzUni;
beforeEach(() => {
    pizzUni = new PizzUni();
})

describe('PizzUni', () => {

    it('test constructor', () => {

        assert.deepEqual(pizzUni.registeredUsers, []);
        assert.deepEqual(pizzUni.orders, []);
        assert.deepEqual(pizzUni.availableProducts, {
            pizzas: ['Italian Style', 'Barbeque Classic', 'Classic Margherita'],
            drinks: ['Coca-Cola', 'Fanta', 'Water']
        });
    })
    it('test registerUser', () => {

        pizzUni.registerUser('pesho@gmail.com')
        assert.throw(() => pizzUni.registerUser('pesho@gmail.com'),
            `This email address (pesho@gmail.com) is already being used!`);
        assert.deepEqual(pizzUni.registerUser('gosho@gmail.com'), { email: 'gosho@gmail.com', orderHistory: [] }
        )

    })
    it('test makeAnOrder', () => {

        assert.throw(() => pizzUni.makeAnOrder('pesho@gmail.com', 'Italian Style', 'Coca-Cola'),
            'You must be registered to make orders!');

        pizzUni.registerUser('pesho@gmail.com');
        assert.throw(() => pizzUni.makeAnOrder('pesho@gmail.com', 'Quatro Stadjone', 'Coca-Cola'),
            'You must order at least 1 Pizza to finish the order.');

        assert.deepEqual(pizzUni.makeAnOrder('pesho@gmail.com', 'Italian Style', 'Coca-Cola'), 0)
        //Todo
    })
    it('test completeOrder', () => {

        pizzUni.registerUser('pesho@gmail.com');
        pizzUni.makeAnOrder('pesho@gmail.com', 'Italian Style', 'Coca-Cola');
        assert.deepEqual(pizzUni.completeOrder(), {
            orderedPizza: 'Italian Style',
            orderedDrink: 'Coca-Cola',
            email: 'pesho@gmail.com',
            status: 'completed'
        })
      
    })
    it('test detailsAboutMyOrder', () => {

        pizzUni.registerUser('pesho@gmail.com');
        pizzUni.makeAnOrder('pesho@gmail.com', 'Italian Style', 'Coca-Cola');
        assert.deepEqual(pizzUni.detailsAboutMyOrder(0), 'Status of your order: pending')
                 
    })
    it('test  doesTheUserExist', () => {

        pizzUni.registerUser('pesho@gmail.com');
        pizzUni.makeAnOrder('pesho@gmail.com', 'Italian Style', 'Coca-Cola');
        assert.deepEqual(pizzUni.doesTheUserExist('pesho@gmail.com'), {
            email: 'pesho@gmail.com',
            orderHistory: [ { orderedPizza: 'Italian Style', orderedDrink: 'Coca-Cola' } ]
          })
          

    })

})