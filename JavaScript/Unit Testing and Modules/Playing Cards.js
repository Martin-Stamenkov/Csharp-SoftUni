function solve(face, suit) {
    const facesCards = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
    const suitsCards = { 'S': '\u2660', 'H': '\u2665', 'D': '\u2666', 'C': '\u2663' }

    class Card {
        constructor(face, suit) {
            this.face = face;
            this.suit = suit;
        }

        get face() {
          return  this._face;
        }
        set face(value) {
            if (!facesCards.includes(value)) {
                throw Error('Error');
            }
             this._face = value
        }
        get suit() {
            return this._suit

        }
        set suit(value) {
            if (!Object.keys(suitsCards).includes(value)) {
                throw Error('Error');
            }
            this._suit = value;
        }
        toString() {

            return `${this.face}${suitsCards[this.suit]}`;
        }
    }
    let card = new Card(face, suit);
    return card.toString()
}
console.log(solve('A', 'S'))
console.log(solve('10', 'H'))
console.log(solve('J', 'D'))