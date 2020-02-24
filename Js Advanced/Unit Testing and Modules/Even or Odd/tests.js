let isOddOrEven = require('./EvenOrOdd.js')
let assert = require('chai').assert

describe('isOddOrEven', () => {

    it('not string return undifined', () => {
        assert.equal(isOddOrEven(15), undefined)
    })
    it('return even', () => {
        assert.equal(isOddOrEven('mama'),'even')
    })
    it('return odd', () => {
        assert.equal(isOddOrEven('Gosho'),'odd')
    })
})