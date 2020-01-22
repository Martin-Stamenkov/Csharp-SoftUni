function solve(input) {

    const parsedJucies = {};
    const bottledJucies = {};

    for (let i = 0; i < input.length; i++) {
        let tempParsedJucies = input[i].split(' => ');
        let juice = tempParsedJucies[0];
        let quantity = tempParsedJucies[1];

        if (parsedJucies[juice]) {
            parsedJucies[juice] += Number(quantity);
        } else {
            parsedJucies[juice] = Number(quantity);
        }

        let bottledQuantity = Math.floor(parsedJucies[juice] / 1000);

        if (bottledQuantity > 0) {
            bottledJucies[juice] = bottledQuantity;
        }
    }
        let output = Object.entries(bottledJucies);

        for (let i = 0; i < output.length; i++) {
            console.log(output[i].join(' => '));
        }

    //return parsedJucies;
}
console.log(solve(['Orange => 2000',
    'Peach => 1432',
    'Banana => 450',
    'Peach => 600',
    'Strawberry => 549']));