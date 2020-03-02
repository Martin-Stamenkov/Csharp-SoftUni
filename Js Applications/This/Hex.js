class Hex {
    constructor(value) {
        this.value = value;
    }
    valueOf() {
        return this.value;
    }
    toString() {
        let result = this.value.toString(16).toUpperCase()
        return '0x' + result
    }
    plus(number) {

        return new Hex(this.value + number);
    }
    minus(number) {
        return new Hex(this.value - number);
    }
    parse(string) {
        return this.value = parseInt(string, 16)
    }
}
let FF = new Hex(255);
console.log(FF.toString());
console.log(FF.valueOf() + 1 == 256);
console.log(FF.valueOf());
let a = new Hex(10);
let b = new Hex(5);
console.log(a.plus(b).toString());
console.log(a.plus(b).toString() === '0xF');
console.log(a.parse('0xF'));