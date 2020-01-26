function solve(input) {

    let parsedData = input.reduce((acc, curr) => {

        let [town, productName,quantityPrice] = curr.split(' -> ');
        let [amountOfSales, priceForOneUnit] = quantityPrice.split(' : ');

        if (!acc[town]) {
            acc[town] = {};
        }
        acc[town][productName] = 0;
        acc[town][productName] = +amountOfSales*+priceForOneUnit;

        return acc;
    }, {})

    for (const [town , products] of Object.entries(parsedData)) {
        
        console.log(`Town - ${town}`)

        for (const [product , income] of Object.entries(products)) {

            console.log(`$$$${product} : ${income}`);
            
        }
    }
}
solve(['Sofia -> Laptops HP -> 200 : 2000',
    'Sofia -> Raspberry -> 200000 : 1500',
    'Sofia -> Audi Q7 -> 200 : 100000',
    'Montana -> Portokals -> 200000 : 1',
    'Montana -> Qgodas -> 20000 : 0.2',
    'Montana -> Chereshas -> 1000 : 0.3'])