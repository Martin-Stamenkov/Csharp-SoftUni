function solve(input) {

    let myArray = [];
    for (let i = 0; i < input.length; i++) {
        if (i % 2 == 0) {

            myArray.push(input[i])
        }
    }
    console.log(myArray.join(' '))
}
solve(['20', '30', '40'])