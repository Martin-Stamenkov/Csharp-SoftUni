let rgbToHexColor = require(`./RGBtoHex.js`);
let assert = require(`chai`).assert;

describe('rgbToHexColor tests', () => {
    it('return undifined if some argument is NAN', () => {

        assert.equal(rgbToHexColor(12, 15, 'red'), undefined)
        assert.equal(rgbToHexColor(12, 'green', 15), undefined)
        assert.equal(rgbToHexColor('blue', 12, 15), undefined)
        assert.equal(rgbToHexColor({}, 12, 15), undefined)
        assert.equal(rgbToHexColor(12, {}, 15), undefined)
        assert.equal(rgbToHexColor(15, 12, {}), undefined)
        assert.equal(rgbToHexColor(15, 12, []), undefined)
        assert.equal(rgbToHexColor(15, [], 12), undefined)
        assert.equal(rgbToHexColor([], 12, 15), undefined)
        assert.equal(rgbToHexColor(1.2, 12, 15), undefined)
        assert.equal(rgbToHexColor(12, 1.2, 15), undefined)
        assert.equal(rgbToHexColor(15, 12, 1.2), undefined)
    })
    it('return undifined if some argument is > 255', () => {

        assert.equal(rgbToHexColor(12, 15, 256), undefined)
        assert.equal(rgbToHexColor(12, 256, 15), undefined)
        assert.equal(rgbToHexColor(256, 12, 15), undefined)
    })
    it('return undifined if some  argument is < 0', () => {

        assert.equal(rgbToHexColor(12, 15, -1), undefined)
        assert.equal(rgbToHexColor(12, -1, 15), undefined)
        assert.equal(rgbToHexColor(-1, 12, 15), undefined)
    })
    it('return hexadecimal format', () => {

        assert.equal(rgbToHexColor(5, 5, 5), '#050505')
        assert.equal(rgbToHexColor(10, 15, 20), '##0A0F14')
        assert.equal(rgbToHexColor(14, 14, 14), '##0E0E0E')
    })

}) 