function solve(input) {
    let firstEl = parseInt(input[0]);

    for (let i = 1; i < input.length; i++) {
        switch (input[i]) {
            case 'chop':
                firstEl /= 2;
                console.log(firstEl)
                break;
            case 'dice':
               firstEl = Math.sqrt(firstEl)
                console.log(firstEl)
                break;
            case 'spice':
                firstEl++;
                console.log(firstEl)
                break;
            case 'bake':
                firstEl *= 3;
                console.log(firstEl)
                break;
            case 'fillet':
                firstEl -= firstEl *0.2;
                console.log(firstEl)
                break;
        }
    }
}
solve(['9', 'dice', 'spice', 'chop', 'bake', 'fillet'])