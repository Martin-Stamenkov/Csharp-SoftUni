let lookupChar = require('./Char Lookup.js');
let assert = require('chai').assert

describe('lookupChar', () => {

    it('return undefined if string or index are invalid', () => {

        assert.equal(lookupChar('Pesho', '5'), undefined);
        assert.equal(lookupChar('Pesho', 5.5), undefined);
        assert.equal(lookupChar(5, 5), undefined);
    })
    it('return incorectIndex if index is invalid', () => {

        assert.equal(lookupChar('Pesho', -5), 'Incorrect index');
        assert.equal(lookupChar('Pesho', 5), 'Incorrect index');
        assert.equal(lookupChar('Pesho', 6), 'Incorrect index');
        assert.equal(lookupChar('', 6), 'Incorrect index');
    })
    it('method should work correctly', () => {

        assert.equal(lookupChar('Pesho', 0), 'P');
        assert.equal(lookupChar('Pesho', 2), 's');
        assert.equal(lookupChar('Pesho', 4), 'o');
    })
})