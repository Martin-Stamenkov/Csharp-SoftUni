let Parser = require("./solution.js");
let assert = require("chai").assert;

let parser;

beforeEach(() => {

    parser = new Parser('[ {"Nancy":"architect"},{"John":"developer"},{"Kate": "HR"} ]')

})
describe("MyTests", () => {

    it('test Constructor', () => {

        assert.deepEqual(parser._data,[ { Nancy: 'architect' }, { John: 'developer' }, { Kate: 'HR' } ])
        assert.deepEqual(parser._log , [])
       // assert.deepEqual(parser._addToLog,parser._addToLogInitial()) //Todo
    })
    it('test getData', () => {

        assert.deepEqual(parser.data,[ { Nancy: 'architect' }, { John: 'developer' }, { Kate: 'HR' } ])
    })
    it('test print', () => {

        parser = new Parser('[ {"Nancy":"architect"}]')
        assert.deepEqual(parser.print(),'id|name|position\n0|Nancy|architect')
    })
    it('test addEntries', () => {

        parser = new Parser('[ {"Nancy":"architect"}]')
        assert.deepEqual(parser.addEntries("Steven:tech-support Edd:administrator"),'Entries added!')
    })
    it('test remove throw Ex', () => {

        //parser = new Parser('[ {"Nancy":"architect"}]')
        assert.throws(() => parser.removeEntry(1),"There is no such entry!")
    })
});