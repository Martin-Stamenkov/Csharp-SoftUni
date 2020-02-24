function solve(input) {

    let myArray = input.map(Number);

    let firstEl = myArray[0];
    let lastEl = myArray[myArray.length - 1];
    let result = firstEl + lastEl;
    console.log(result);

}
solve(['20', '30', '40'])