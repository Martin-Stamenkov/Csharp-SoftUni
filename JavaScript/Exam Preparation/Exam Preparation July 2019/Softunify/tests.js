let SoftUniFy = require('./03. Softunify_Ресурси')
let assert = require('chai').assert

let softUniFy;
beforeEach(() => {
    softUniFy = new SoftUniFy();
})

describe('test SoftUniFy', () => {

    it('test constructor', () => {

        assert.deepEqual(softUniFy.allSongs, {})
    })

    it('test downloadSong', () => {

        assert.deepEqual(softUniFy.downloadSong('LP', 'Numb', 'Any'), { allSongs: { LP: { rate: 0, votes: 0, songs: ['Numb - Any'] } } })

    })
    it('test playSong', () => {
        (
            assert.equal(softUniFy.playSong('Numb')
                , 'You have not downloaded a Numb song yet. Use SoftUniFy\'s function downloadSong() to change that!'))
        softUniFy.downloadSong('LP', 'Numb', 'Any')
        assert.deepEqual(softUniFy.playSong('Numb'), 'LP:' + '\nNumb - Any\n')
    })
    it('test songsList', () => {

        assert.deepEqual(softUniFy.songsList, 'Your song list is empty')
        softUniFy.downloadSong('LP', 'Numb', 'Any');
        softUniFy.downloadSong('Limp Bizkit', 'Rollin', 'We Rollin');
        assert.deepEqual(softUniFy.songsList, 'Numb - Any\nRollin - We Rollin')

    })
    it('test rateArtist', () => {

        assert.deepEqual(softUniFy.rateArtist('LP'), `The LP is not on your artist list.`)
        softUniFy.downloadSong('LP', 'Numb', 'Any');
        assert.deepEqual(softUniFy.rateArtist('LP', 50), 50)

    })


});