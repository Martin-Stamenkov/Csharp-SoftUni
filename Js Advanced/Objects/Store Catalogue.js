function solve(input) {

    let reducedData = input.reduce((acc, productLine) => {
        let [product, price] = productLine.split(':').map(x => x.trim());

        if (acc[product[0]]) {
            acc[product[0]] = [...acc[product[0]], productLine];
        } else {
            acc[product[0]] = [productLine];
        }
        return acc;

    }, {})
    //console.log(reducedData);
   Object.keys(reducedData).sort().map(x=>{
       console.log(x);
       reducedData[x].sort().map(x=>{
           console.log(`  ${x.split(' : ').join(': ')}`);
       })
  
   })

}
solve(['Appricot : 20.4',
    'Fridge : 1500',
    'TV : 1499',
    'Deodorant : 10',
    'Boiler : 300',
    'Apple : 1.25',
    'Anti-Bug Spray : 15',
    'T-Shirt : 10']);