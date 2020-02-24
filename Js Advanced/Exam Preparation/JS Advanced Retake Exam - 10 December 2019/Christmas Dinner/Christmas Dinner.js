class ChristmasDinner {

    constructor(budget) {
        this.budget = budget
        this.dishes = []
        this.products = []
        this.guests = {}
    }

    get budget() {
        return this._budget;
    }

    set budget(value) {
        if (value < 0) {
            throw new Error("The budget cannot be a negative number")
        }
        return this._budget = value;
    }

    shopping(product) {
        let type = product[0];
        let price = Number(product[1]);

        if (this.budget < price) {
            throw new Error("Not enough money to buy this product")
        } else {
            this.products.push(type);
            this.budget -= price;
            return `You have successfully bought ${type}!`;
        }
    }
    recipes(recipe) {
        let recipeName = recipe.recipeName;
        let productsList = recipe.productsList;

        recipe.productsList.forEach(product => {
            if (!this.products.includes(product)) {
                throw new Error("We do not have this product")
            }
        });
        this.dishes.push(recipe);
        return `${recipeName} has been successfully cooked!`

    }
    inviteGuests(name, dish) {
        let currentDish = this.dishes.find(x => x.recipeName === dish)

        if (!currentDish) {
            throw new Error("We do not have this dish");
        }
        if (!this.guests[name]) {
            this.guests[name] = dish;
            return `You have successfully invited ${name}!`
        }
        throw new Error(`This guest has already been invited`)
    }
    showAttendance() {
        let output = '';
        for (const guest in this.guests) {
            let currentDish = this.dishes.find(x => x.recipeName === this.guests[guest])

            output +=`\n${guest} will eat ${this.guests[guest]}, which consists of ${currentDish.productsList.join(', ')}`
        }
        return output.trim()
    }

}
// let dinner = new ChristmasDinner(300);
// console.log(dinner.shopping(['Salt', 1]));
// dinner.shopping(['Beans', 3]);
// dinner.shopping(['Cabbage', 4]);
// dinner.shopping(['Rice', 2]);
// dinner.shopping(['Savory', 1]);
// dinner.shopping(['Peppers', 1]);
// dinner.shopping(['Fruits', 40]);
// dinner.shopping(['Honey', 10]);
// dinner.recipes({
//     recipeName: 'Oshav',
//     productsList: ['Fruits', 'Honey']
// });
// dinner.recipes({
//     recipeName: 'Folded cabbage leaves filled with rice',
//     productsList: ['Cabbage', 'Rice', 'Salt', 'Savory']
// });
// dinner.recipes({
//     recipeName: 'Peppers filled with beans',
//     productsList: ['Beans', 'Peppers', 'Salt']
// });
// dinner.inviteGuests('Ivan', 'Oshav');
// dinner.inviteGuests('Petar', 'Folded cabbage leaves filled with rice');
// dinner.inviteGuests('Georgi', 'Peppers filled with beans');
// console.log(dinner.showAttendance());


