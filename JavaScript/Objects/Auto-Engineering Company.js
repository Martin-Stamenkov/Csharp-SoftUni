function solve(input) {
    let brands = new Map();

    for (const line of input) {
        let tokens = line.split('|').map(x => x.trim());
        let brand = tokens[0];
        let model = tokens[1];
        let produced = +tokens[2];

        if (brands.has(brand)) {
            if (brands.get(brand).has(model)) {
                brands.get(brand).set(model, brands.get(brand).get(model) + produced);
            } else {
                brands.get(brand).set(model, produced)
            }
        } else {
            brands.set(brand, new Map().set(model, produced));
        }

    }
    for (const [brand, models] of brands) {
        console.log(brand);
        for (const [model,totalProduced] of models) {
            console.log(`###${model} -> ${totalProduced}`)
        }
    }
}
solve(['Audi | Q7 | 1000',
    'Audi | Q6 | 100',
    'BMW | X5 | 1000',
    'BMW | X6 | 100',
    'Citroen | C4 | 123',
    'Volga | GAZ-24 | 1000000',
    'Lada | Niva | 1000000',
    'Lada | Jigula | 1000000',
    'Citroen | C4 | 22',
    'Citroen | C5 | 10']);