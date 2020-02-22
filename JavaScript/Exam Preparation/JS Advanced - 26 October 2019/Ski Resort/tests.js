let SkiResort = require('./solution');
let assert = require('chai').assert

let skiResort;

beforeEach(() => {
    skiResort = new SkiResort('Bansko')
})



describe('SkiResort', function () {

    it('test constructor', () => {

        assert.equal(skiResort.name, 'Bansko')
        assert.equal(skiResort.voters, 0)
        assert.deepEqual(skiResort.hotels, [])
    })
    it('test bestHotel', () => {

        assert.deepEqual(skiResort.bestHotel, "No votes yet")
        skiResort.build('Avenue', 5);
        skiResort.leave('Avenue', 3, 0.5);
        assert.deepEqual(skiResort.bestHotel, `Best hotel is Avenue with grade 1.5. Available beds: 8`)
    })
    it('test build', () => {

        assert.throws(() => skiResort.build('', 10), `Invalid input`)
        assert.throws(() => skiResort.build('Avenue', 0), `Invalid input`)
        assert.throws(() => skiResort.build('Avenue', -1), `Invalid input`)
        assert.deepEqual(skiResort.build('Avenue', 10), `Successfully built new hotel - Avenue`)
        assert.deepEqual(skiResort.hotels[0], { name: 'Avenue', beds: 10, points: 0 })

    })
    it('test book', () => {
        skiResort.build('Avenue', 10);
        assert.throws(() => skiResort.book('', 10), `Invalid input`)
        assert.throws(() => skiResort.book('Avenue', 0), `Invalid input`)
        assert.throws(() => skiResort.book('Avenue', -1), `Invalid input`)
        skiResort.build('Rose', 10);
        assert.throws(() => skiResort.book('Orpheus', 10), "There is no such hotel")
        assert.throws(() => skiResort.book('Rose', 12), "here is no free space")
        assert.deepEqual(skiResort.book('Avenue', 10), 'Successfully booked')
        assert.deepEqual(skiResort.hotels[0].beds, 0)

    })
    it('test leave', () => {
        skiResort.build('Avenue', 10);
        skiResort.book('Avenue', 10)
        assert.throws(() => skiResort.leave('', 10, 1), `Invalid input`)
        assert.throws(() => skiResort.leave('Avenue', 0, 1), `Invalid input`)
        assert.throws(() => skiResort.leave('Avenue', -1, 1), `Invalid input`)
        skiResort.build('Rose', 10);
        skiResort.book('Rose', 10);
        assert.throws(() => skiResort.leave('Orpheus', 10, 1), "There is no such hotel")
        assert.deepEqual(skiResort.leave('Rose', 10, 1), `10 people left Rose hotel`)
        // assert.deepEqual(10,skiResort.hotels[1].points)
        // assert.deepEqual(10,skiResort.hotels[1].beds)
        // assert.deepEqual(10,skiResort.hotels[1].voters)
    })
    it('test averageGrade', () => {

        assert.deepEqual(skiResort.averageGrade(), "No votes yet")
        skiResort.build('Avenue', 5);
        skiResort.leave('Avenue', 3, 0.5);
        assert.deepEqual(skiResort.averageGrade(), `Average grade: 0.50`)
    })
});
