function solve(input) {

    console.log(input.flat().sort((a, b) => b - a)[0]);
}
solve([[20, 50, 10], [8, 33, 145]]);