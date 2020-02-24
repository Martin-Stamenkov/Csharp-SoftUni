let sum = require('./Sum of Numbers.js');
let assert = require('chai').assert;

describe('Sum', () => {
    it('take an array of numbers', () => {
        assert.equal(sum([1, 2, 3, 4, 5]), 15)
    })
    it('sum floating-point number', () => {
        assert.equal(sum([1, 2.5, 4.6, 12.8]), 20.9)
    })
    it('retrun empty array', () => {
        assert.equal(sum([]),0)
    })

})