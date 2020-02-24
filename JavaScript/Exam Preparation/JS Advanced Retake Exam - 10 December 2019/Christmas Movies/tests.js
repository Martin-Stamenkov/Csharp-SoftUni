let ChristmasMovies = require('./02. Christmas Movies_Resources');
let assert = require('chai').assert;

let christmas;

beforeEach(() => {
    christmas = new ChristmasMovies()
})

describe(('ChristmasMovies'), () => {

    it('test constructor', () => {

        assert.deepEqual(christmas.movieCollection, []);
        assert.deepEqual(christmas.watched, {});
        assert.deepEqual(christmas.actors, []);
        assert.isObject(christmas.watched);
        assert.isArray(christmas.movieCollection);
        assert.isArray(christmas.actors)
    })

    it('test buyMovie', () => {

        assert.deepEqual('You just got Home Alone to your collection in which Macaulay Culkin, Joe Pesci, Daniel Stern are taking part!',
            christmas.buyMovie('Home Alone', ['Macaulay Culkin', 'Joe Pesci', 'Daniel Stern']));
        christmas.buyMovie('Home Alone 2', ['Macaulay Culkin'])
        assert.throws(() => christmas.buyMovie('Home Alone 2', ['Macaulay Culkin'])
            , `You already own Home Alone 2 in your collection!`)

    })
    it('should add new movie correct with repeated actors', () => {
            assert.equal(christmas.buyMovie('Home Alone', ['Macaulay Culkin', 'Macaulay Culkin', 'Joe Pesci', 'Daniel Stern']), `You just got Home Alone to your collection in which Macaulay Culkin, Joe Pesci, Daniel Stern are taking part!`);
            assert.equal(christmas.movieCollection.length, 1);
            assert.deepEqual(christmas.movieCollection[0], {name:'Home Alone',actors:['Macaulay Culkin','Joe Pesci','Daniel Stern']});
        });
    it('test movieCollection', () => {
        christmas.buyMovie('Home Alone 2', ['Macaulay Culkin'])
        assert.deepEqual({ name: 'Home Alone 2', actors: ['Macaulay Culkin'] }, christmas.movieCollection[0])
        assert.deepEqual(christmas.movieCollection.length, 1);
    })
    it('test discardMovie', () => {

        assert.throws(() => christmas.discardMovie('Home Alone 2'), `Home Alone 2 is not at your collection!`)
        christmas.buyMovie('Home Alone 2', ['Macaulay Culkin']);
        assert.throws(() => christmas.discardMovie('Home Alone 2'), `Home Alone 2 is not watched!`)
    })
    it('test discardMovie when movie is watched and is in collection', () => {

        christmas.buyMovie('Home Alone 2', ['Macaulay Culkin']);
        christmas.watchMovie('Home Alone 2');
        assert.deepEqual(christmas.discardMovie('Home Alone 2'), `You just threw away Home Alone 2!`);
        assert.deepEqual(christmas.movieCollection.length, 0);
        //assert.deepEqual(christmas.watched.length, 0);


    })
    it('test watchMovie', () => {

        christmas.buyMovie('Home Alone 2', ['Macaulay Culkin']);
        assert.deepEqual(christmas.watched['Home Alone 2'], christmas.watchMovie('Home Alone 2'));
        assert.throws(() => christmas.watchMovie('Home Alone'), 'No such movie in your collection!')
    })
    it('test watchMovie increase count', () => {

        christmas.buyMovie('Home Alone 2', ['Macaulay Culkin']);
        christmas.watchMovie('Home Alone 2')
        assert.deepEqual(christmas.watched['Home Alone 2'], 1);
        christmas.watchMovie('Home Alone 2')
        christmas.watchMovie('Home Alone 2')
        assert.deepEqual(christmas.watched['Home Alone 2'], 3);

    })
    it('test favouriteMovie', () => {

        christmas.buyMovie('Home Alone 2', ['Macaulay Culkin']);
        christmas.watchMovie('Home Alone 2');
        assert.deepEqual('Your favourite movie is Home Alone 2 and you have watched it 1 times!', christmas.favouriteMovie());
    })
    it('test favouriteMovie throw error', () => {
        assert.throws(() => christmas.favouriteMovie(), 'You have not watched a movie yet this year!');
    })
    it('test mostStarredActor throw error', () => {
        assert.throws(() => christmas.mostStarredActor(), 'You have not watched a movie yet this year!');
    })
    it('test mostStarredActor', () => {
        christmas.buyMovie('Home Alone 2', ['Macaulay Culkin']);
        christmas.watchMovie('Home Alone 2');
        assert.deepEqual('The most starred actor is Macaulay Culkin and starred in 1 movies!'
            , christmas.mostStarredActor());

    })

})