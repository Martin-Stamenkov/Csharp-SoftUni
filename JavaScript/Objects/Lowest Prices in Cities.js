function solve(input) {

    let products = input.reduce((acc, curr) => {
        let [town, product, price] = curr.split(' | ');
        if (!acc[product]) {
            acc[product] = {};
        }
        if (!acc[product][town]) {
            acc[product][town] = 0;
        }
        acc[product][town] = +price;

        return acc;

    }, {});

    for (const [product, towns] of Object.entries(products)) {
        let lowestPrice = Number.MAX_VALUE;
        let townWithLowestPrice = "";

        for (const [town, price] of Object.entries(towns)) {
            if (lowestPrice>price) {
                lowestPrice = price;
                townWithLowestPrice = town;
            }
        }
        console.log(`${product} -> ${lowestPrice} (${townWithLowestPrice})`);
    }

}
solve(['Sample Town | Sample Product | 1000',
    'Sample Town | Orange | 2',
    'Sample Town | Peach | 1',
    'Sofia | Orange | 3',
    'Sofia | Peach | 2',
    'New York | Sample Product | 1000.1',
    'New York | Burger | 10'])