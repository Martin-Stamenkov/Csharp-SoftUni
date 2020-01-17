function solve(input) {

    let myArray = input.map(Number);
    let result = [];

    for (const element of myArray) {
        if (element < 0) {
            result.unshift(element);

        } else {
            result.push(element)
        }
    }
    result.forEach(element => console.log(element))
}
//solve([3, -2, 0, -1])