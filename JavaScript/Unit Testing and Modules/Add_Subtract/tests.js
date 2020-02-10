let createCalculator = require('./Add _Subtract.js')
let assert = require('chai').assert;

describe('createCalculator', () => {

    let calculator;

    beforeEach(() => {
        calculator = createCalculator();
    })
    it('should return obj with the given properties', () => {
        
        assert.property(calculator, 'add');
        assert.property(calculator, 'subtract');
        assert.property(calculator, 'get');
    })
    it('return object',()=>{
        assert.isObject(calculator)
    })

    it('add property work correctly', () => {

        calculator.add(1)
        calculator.add(2)
        assert.equal(calculator.get(), 3)
    })
    it('add property work correctly with decimal', () => {

        calculator.add(1.1)
        calculator.add(1.1)
        assert.equal(calculator.get(), 2.2)

    })
    it('add property work correctly with string', () => {

        calculator.add(1)
        calculator.add('1')
        assert.equal(calculator.get(), 2)

    })
    it('substract property work correctly', () => {

        calculator.add(2)
        calculator.subtract(1)
        assert.equal(calculator.get(), 1)
    })
    it('substract property work correctly with decimal', () => {

        calculator.add(2.2)
        calculator.subtract(1.1)
        assert.equal(calculator.get(), 1.1)

    })
    it('substract property work correctly with string', () => {

        calculator.add(2)
        calculator.subtract('1')
        assert.equal(calculator.get(), 1)

    })

    it('get property work correctly', () => {

        calculator.add(2)
        calculator.subtract(1)
        let result = calculator.get();
        assert.equal(calculator.get(), result)
    })
    it('return 0 for get', () => {

        assert.equal(calculator.get(), 0)
    })
  
})