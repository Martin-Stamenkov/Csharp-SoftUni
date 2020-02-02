function solve() {


    let robot = {

        ingredients: {
            protein: 0,
            carbohydrate: 0,
            fat: 0,
            flavour: 0,
        },

        library: {
            apple: { carbohydrate: 1, flavour: 2 },
            lemonade: { carbohydrate: 10, flavour: 20 },
            burger: { carbohydrate: 5, fat: 7, flavour: 3 },
            eggs: { protein: 5, fat: 1, flavour: 1 },
            turkey: { protein: 10, carbohydrate: 10, fat: 10, flavour: 10 }

        },

        commands: {
            restock: (microelement, quantity) => {
                robot.ingredients[microelement] += Number(quantity)
                return 'Success';
            },
            prepare: (recipe, quantity) => {
                let food = robot.library[recipe];
                if (food) {
                    for (const [name, value] of Object.entries(food)) {
                        if (robot.ingredients[name] < value * quantity) {
                            return `Error: not enough ${name} in stock`
                        }
                        robot.ingredients[name] -= value * quantity;
                        return 'Success';
                    }
                }
            },
            report: () => 
                Object.keys(robot.ingredients).map(x => `${x}=${robot.ingredients[x]}`).join(' ')
            
        }

    };
    return function (input) {

        let args = input.split(' ');
        let command = args[0];
        if (robot.commands[command]) {
            return robot.commands[command](args[1], args[2]);
        }
    }

}

let manager = solve();
console.log(manager('prepare turkey 1'));
console.log(manager('restock protein 10'));
console.log(manager('prepare turkey 1'));
console.log(manager('restock carbohydrate 10'));
console.log(manager('prepare turkey 1'));
console.log(manager('restock fat 10'));
console.log(manager('prepare turkey 1'));
console.log(manager('restock flavour 10'));
console.log(manager('prepare turkey 1'));
console.log(manager('report'));