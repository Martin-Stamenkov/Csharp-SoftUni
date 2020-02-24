let FilmStudio = require('./filmStudio');
let assert = require('chai').assert;


let studio;

beforeEach(() => {
    studio = new FilmStudio('LucasFilm');
})

describe('FilmStudio', () => {

    it('test constructor', () => {

        assert.equal(studio.name, 'LucasFilm');
        assert.deepEqual(studio.films, []);
    })
    it('test makeMovie', () => {
        assert.throw(() => studio.makeMovie(12, ['Hulk', 'Thor', 'Arrow']), 'Invalid arguments')
        assert.throw(() => studio.makeMovie('Avengers', 'Hulk'), 'Invalid arguments')
        assert.throw(() => studio.makeMovie('Hulk'), 'Invalid arguments count')
        assert.deepEqual(studio.makeMovie('The Avengers', ['Iron-Man', 'Thor', 'Hulk', 'Arrow guy']), {
            filmName: 'The Avengers',
            filmRoles: [
                { role: 'Iron-Man', actor: false },
                { role: 'Thor', actor: false },
                { role: 'Hulk', actor: false },
                { role: 'Arrow guy', actor: false }
            ]}
        )
    })
    it('test casting', () => {

        assert.deepEqual(studio.casting('Gosho','Thor'),`There are no films yet in LucasFilm.`);
        studio.makeMovie('StarWars',['Yoda','baby Yoda']);
        assert.deepEqual(studio.casting('Pesho','baby Yoda'),
        `You got the job! Mr. Pesho you are next baby Yoda in the StarWars. Congratz!`);
        assert.deepEqual(studio.casting('Gosho','Thor'),`Gosho, we cannot find a Thor role...`);
    })
    it('test lookForProducer', () => {

       assert.throws(() => studio.lookForProducer('StarWars'),`StarWars do not exist yet, but we need the money...`)
       studio.makeMovie('StarWars',['Yoda']);
       assert.deepEqual(studio.lookForProducer('StarWars'),'Film name: StarWars\nCast:\nfalse as Yoda\n')
    })
})
