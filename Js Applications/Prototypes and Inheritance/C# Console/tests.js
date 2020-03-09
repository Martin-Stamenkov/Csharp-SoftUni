let Console = require('./Console');
let assert = require('chai').assert

describe('C# console', () => {

    describe('test with single argument', () => {
        it('test with string', () => {
            assert.equal(Console.writeLine('Pesho'), 'Pesho')
        })
        it('test with object', () => {
            assert.equal(Console.writeLine({ name: 'Pesho' }), JSON.stringify({ "name": "Pesho" }))

        })
        it('test with array', () => {
            assert.equal(Console.writeLine(['Pesho', 'Gosho']), JSON.stringify(["Pesho", "Gosho"]))
        })
        it('test placeholder', () => {
            assert.deepEqual(Console.placeholder, /{\d+}/g)
        })
        it('throw error ', () => {
            assert.throws(() => Console.writeLine(), 'No string format given!')
        })
    })
    describe('test with more arguments', () => {
        it('test correctly', () => {
            assert.equal(Console.writeLine("The sum of {0} and {1} is {2}", 3, 4, 7), 'The sum of 3 and 4 is 7')
        })
        it('test invalid arguments', () => {
            assert.throws(() => Console.writeLine("The sum of {0} and {1} is {2}", 3, 4), 'Incorrect amount of parameters given!')

        })
        it('test invalid placehodlers', () => {
            assert.throws(() => Console.writeLine("The sum of {0} and {1} is {1}", 3, 4, 7), 'Incorrect placeholders given!')

        })
    })
})