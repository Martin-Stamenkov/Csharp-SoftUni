function solve(input) {

    let myArray = [];
    for (let i = 0; i < input.length; i++) {

        if (i % 2 == 1) {
            myArray.push(input[i] * 2);
        }
    }
    myArray.reverse();
    console.log(myArray.join(' '));
}
solve([3, 0, 10, 4, 7, 3])