function solve() {

    class Melon {
        constructor(weight, melonSort) {
            if (new.target === Melon) {
                throw new TypeError("Abstract class cannot be instantiated directly");
            }
            this.weight = weight;
            this.melonSort = melonSort;
        }

    }
    class Watermelon extends Melon {
        constructor(weight, melonSort) {
            super(weight, melonSort)
            this._elementIndex = this.weight * this.melonSort.length;
            this.element = 'Water'
        }
        get elementIndex() {
            return this._elementIndex
        }
        toString(){
            return `Element: Water\nSort: ${this.melonSort}\nElement Index: ${this.elementIndex}`;
        }
    }
    class Firemelon extends Melon {
        constructor(weight, melonSort) {
            super(weight, melonSort)
            this._elementIndex = this.weight * this.melonSort.length;
            this.element = 'Fire'
        }
        get elementIndex() {
            return this._elementIndex
        }
        toString(){
            return `Element: Fire\nSort: ${this.melonSort}\nElement Index: ${this.elementIndex}`;
        }
    }
    class Earthmelon extends Melon {
        constructor(weight, melonSort) {
            super(weight, melonSort)
            this._elementIndex = this.weight * this.melonSort.length;
            this.element = 'Earth'
        }
        get elementIndex() {
            return this._elementIndex
        }
        toString(){
            return `Element: Earth\nSort: ${this.melonSort}\nElement Index: ${this.elementIndex}`;
        }
    }
    class Airmelon extends Melon {
        constructor(weight, melonSort) {
            super(weight, melonSort)
            this._elementIndex = this.weight * this.melonSort.length;
            this.element = 'Air'
        }
        get elementIndex() {
            return this._elementIndex
        }
        toString(){
            return `Element: Air\nSort: ${this.melonSort}\nElement Index: ${this.elementIndex}`;
        }
    }
    let watermelon = new Watermelon(12.5, "Kingsize");
    console.log(watermelon.toString());
    return{
        Melon,
        Watermelon,
        Airmelon,
        Firemelon,
        Earthmelon
    }
}
solve()