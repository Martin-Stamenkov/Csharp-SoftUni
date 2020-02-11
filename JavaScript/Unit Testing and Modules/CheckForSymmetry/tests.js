let isSymmetric = require('./Check for Symmetry.js');
let assert = require('chai').assert;

describe('isSymmetric', () => {
    it('Is not Array and return false', () => {
        assert.equal(isSymmetric('Gosho'), false);
        assert.equal(isSymmetric(12345), false);
        assert.equal(isSymmetric({}), false);
    })
    it('If IsSymmetric return true', () => {
        assert.equal(isSymmetric([1, 2, 3, 2, 1]), true);
        assert.equal(isSymmetric(['a', 'b', 'c', 'b', 'a']), true);
        assert.equal(isSymmetric(['a', 1, 'c', 1, 'a']), true);
        assert.equal(isSymmetric([{},'a', 1, 'c', 1, 'a',{}]), true);
    })
    it('Empty Array return true', () => {
        assert.equal(isSymmetric([]), true);
    })
    it('Empty function return false', () => {
        assert.equal(isSymmetric(), false);
    })
    it('Not Symmetric return false', () => {
        assert.equal(isSymmetric([1, 2, 3, 4, 5]), false);
        assert.equal(isSymmetric(['a', 'b', 'c', 'b', 'c']), false);
    })
})