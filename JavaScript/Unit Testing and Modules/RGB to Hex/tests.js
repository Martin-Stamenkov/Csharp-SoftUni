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
    it('should return valid hex', () => {
        assert.equal(rgbToHexColor(1, 1, 1), '#010101');
        assert.equal(rgbToHexColor(255, 255, 255), '#FFFFFF');
        assert.equal(rgbToHexColor(1, 100, 200), '#0164C8');
        assert.equal(rgbToHexColor(0, 0, 0), '#000000');
    });
}) 
