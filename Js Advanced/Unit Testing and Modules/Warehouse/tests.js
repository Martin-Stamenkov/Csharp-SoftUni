let Warehouse = require('./Warehouse');
let assert = require('chai').assert;

describe("test constructor and capacity", () => {

    it("test capacity", () => {

        assert.throw(() => new Warehouse(-5), `Invalid given warehouse space`)
        assert.throw(() => new Warehouse(0), `Invalid given warehouse space`)
        assert.throw(() => new Warehouse('5'), `Invalid given warehouse space`)
        assert.throw(() => new Warehouse([]), `Invalid given warehouse space`)
        assert.throw(() => new Warehouse({}), `Invalid given warehouse space`)

    });

    it("test constructor", () => {

        let warehouse = new Warehouse(5)
        assert.equal(warehouse._capacity, 5)
        let warehouse2 = new Warehouse(20.5)
        assert.equal(warehouse2._capacity, 20.5)
        assert.isObject(warehouse.availableProducts);
        assert.property(warehouse.availableProducts, 'Drink');
        assert.property(warehouse.availableProducts, 'Food');
    });
});

describe("test AddProduct", () => {
    it("should added products correctly", () => {
        let warehouse = new Warehouse(50);
        warehouse.addProduct('Drink', 'Cola', 5);
        assert.deepEqual(warehouse.availableProducts.Drink, { Cola: 5 })

    });
    it("test when product is added more than once", () => {
        let warehouse = new Warehouse(50);
        warehouse.addProduct('Drink', 'Cola', 5);
        warehouse.addProduct('Drink', 'Cola', 10);
        assert.deepEqual(warehouse.availableProducts.Drink, { Cola: 15 })

    });
    it("should throw exception if capacity is full", () => {
        let warehouse = new Warehouse(50);

        assert.throw(() => warehouse.addProduct('Drink', 'Cola', 55), "There is not enough space or the warehouse is already full")
        assert.throw(() => warehouse.addProduct('Food', 'Burger', 55), "There is not enough space or the warehouse is already full")
    });
});
describe("test orderProducts", () => {
    it("should order products correctly", () => {
        let warehouse = new Warehouse(50);
        warehouse.addProduct('Drink', 'Cola', 10)
        warehouse.addProduct('Drink', 'Fanta', 20)
        warehouse.addProduct('Drink', 'Sprite', 2)
        assert.deepEqual(warehouse.orderProducts('Drink'), { 'Fanta': 20, 'Cola': 10, 'Sprite': 2 })
    });
});
describe("test occupiedCapacity", () => {
    it("should retrun occupied capacity", () => {
        let warehouse = new Warehouse(50);
        warehouse.addProduct('Drink', 'Cola', 10)
        warehouse.addProduct('Drink', 'Fanta', 20)
        warehouse.addProduct('Drink', 'Sprite', 2)
        warehouse.occupiedCapacity()
        assert.equal(warehouse.occupiedCapacity(), 32)
    });
    it("should retrun 0 if warehouse is empty", () => {
        let warehouse = new Warehouse(50);
        assert.equal(warehouse.occupiedCapacity(), 0)
    });
});
describe("test revision", () => {
    it("should work correctly", () => {
        let warehouse = new Warehouse(50);
        warehouse.addProduct('Drink', 'Cola', 10)
        warehouse.addProduct('Drink', 'Fanta', 20)
        warehouse.addProduct('Drink', 'Sprite', 2)
        let output = "";
        for (let type of Object.keys(warehouse.availableProducts)) {
            output += `Product type - [${type}]\n`;
            for (let product of Object.keys(warehouse.availableProducts[type])) {
                output += `- ${product} ${warehouse.availableProducts[type][product]}\n`;
            }
        }
        assert.equal(warehouse.revision(), output.trim())
    });
    it("test when ocuppied capacity is empty", () => {
        let warehouse = new Warehouse(50);
        assert.deepEqual(warehouse.revision(), 'The warehouse is empty')
    });

});
describe("test scrapeProduct", () => {
    it("should work correctly", () => {
        let warehouse = new Warehouse(50);
        warehouse.addProduct('Drink', 'Cola', 10)
        warehouse.addProduct('Drink', 'Fanta', 20)
        warehouse.addProduct('Drink', 'Sprite', 2)

        assert.deepEqual(warehouse.scrapeAProduct('Cola', 5), { Sprite: 2, Cola: 5, Fanta: 20 })
    });
    it("test when quantity is more than quantity of the given product", () => {
        let warehouse = new Warehouse(50);
        warehouse.addProduct('Drink', 'Cola', 10)
        warehouse.addProduct('Drink', 'Fanta', 20)
        warehouse.addProduct('Drink', 'Sprite', 2)

        assert.deepEqual(warehouse.scrapeAProduct('Cola', 20), { Sprite: 2, Cola: 0, Fanta: 20 })
    });
    it("throw exception when product does`n exist", () => {
        let warehouse = new Warehouse(50);
        warehouse.addProduct('Drink', 'Cola', 10)
        warehouse.addProduct('Drink', 'Fanta', 20)
        warehouse.addProduct('Drink', 'Sprite', 2)

        assert.throw(() => warehouse.scrapeAProduct('Milk', 20), `Milk do not exists`)
    });

});
