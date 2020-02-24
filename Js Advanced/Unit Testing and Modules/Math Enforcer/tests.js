let mathEnforcer = require('./Math Enforcer.js');
let assert = require('chai').assert;

describe('Math Enforcer', () => {

    it('should return undefined if param is not a number', () => {
        assert.equal(mathEnforcer.addFive('5'), undefined)
        assert.equal(mathEnforcer.addFive({}), undefined)
        assert.equal(mathEnforcer.subtractTen('5'), undefined)
        assert.equal(mathEnforcer.subtractTen({}), undefined)

    })
    it('method addFive should work correctly', () => {
        assert.equal(mathEnforcer.addFive(5), 10)
        assert.equal(mathEnforcer.addFive(-5), 0)
        assert.equal(mathEnforcer.addFive(2.5), 7.5)
    })
    it('method subtractTen should work correctly', () => {
        assert.equal(mathEnforcer.subtractTen(5), -5)
        assert.equal(mathEnforcer.subtractTen(-5), -15)
        assert.equal(mathEnforcer.subtractTen(10), 0)
        assert.equal(mathEnforcer.subtractTen(15.5), 5.5)
        assert.closeTo(mathEnforcer.subtractTen(11.7), 1.7, 0.01)

    })
    it('method sum should return undefined ig arguments are invalid', () => {
        assert.equal(mathEnforcer.sum('5', 5), undefined)
        assert.equal(mathEnforcer.sum(5, '5'), undefined)
    })
    it('method sum should work correctly', () => {
        assert.equal(mathEnforcer.sum(5, 5), 10)
        assert.equal(mathEnforcer.sum(2.5, 2.5), 5);
        assert.equal(mathEnforcer.sum(5, 2.5), 7.5);
        assert.equal(mathEnforcer.sum(-5, -5), -10);
    })
})