let StringBuilder = require('./String Builder')
let assert = require('chai').assert;
let sb;
beforeEach(() => {
    sb = new StringBuilder();
})

describe("test constructor", () => {

    it("without param", () => {
        assert.deepEqual(new StringBuilder()._stringArray, [])
    });

    it("with param", () => {
        assert.deepEqual(new StringBuilder('Gosho')._stringArray, ['G', 'o', 's', 'h', 'o'])
    });
    it("test static method", () => {
        assert.throws(() => new StringBuilder(1234), 'Argument must be string')
        assert.throws(() => new StringBuilder({}), 'Argument must be string')
        assert.throws(() => new StringBuilder(true), 'Argument must be string')
    });
    it("includes all propertie", () => {
        assert.isFunction(StringBuilder.prototype.append);
        assert.isFunction(StringBuilder.prototype.prepend);
        assert.isFunction(StringBuilder.prototype.insertAt);
        assert.isFunction(StringBuilder.prototype.remove);
        assert.isFunction(StringBuilder.prototype.toString);
       
    });
});
describe("test append ", () => {

    it("with valid string", () => {
        sb.append('hello')
        assert.deepEqual(sb._stringArray, ['h', 'e', 'l', 'l', 'o'])
    });
    it("with existing string", () => {
        sb.append('hello')
        sb.append('hi')
        assert.deepEqual(sb._stringArray, ['h', 'e', 'l', 'l', 'o', 'h', 'i'])
    });
    it("with invalid string", () => {
        assert.throws(() => sb.append(1234), 'Argument must be string')
    });
});
describe("test prepend ", () => {

    it("with valid string", () => {
        sb.append('hi')
        sb.prepend('there')
        assert.deepEqual(sb._stringArray, ['t', 'h', 'e', 'r', 'e', 'h', 'i'])
    });
    it("with invalid string", () => {
        assert.throws(() => sb.prepend(1234), 'Argument must be string')
    });
});
describe("test insertAt ", () => {

    it("with valid string", () => {

        sb.append('hi ')
        sb.insertAt('mate', 2)
        assert.deepEqual(sb._stringArray, ['h', 'i', 'm', 'a', 't', 'e', ' '])
    });
    it("with invalid string", () => {
        sb.append('hi')
        assert.throws(() => sb.insertAt(12, 2), 'Argument must be string')
    });
});
describe("test remove ", () => {

    it("remove", () => {

        sb.append('hello world')
        sb.remove(0, 2)
        assert.deepEqual(sb._stringArray, ['l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd'])
    });
    it("remove with high length", () => {

        sb.append('hello world')
        sb.remove(9, 3)
        assert.deepEqual(sb._stringArray, ['h', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r'])
    });
    it("remove with zero length", () => {

        sb.append('hello')
        sb.remove(1, 0)
        assert.deepEqual(sb._stringArray, ['h', 'e', 'l', 'l', 'o'])
    });

});
describe("test toString ", () => {

    it("toString", () => {

        sb.append('hello world')
        sb.append(' ,welcome')
        assert.deepEqual(sb.toString(), 'hello world ,welcome')
    });

});
