function solve(input) {
    input = input.map(Number);
    const myArr = [input.shift(input[0])];
    let count = 0;
    while (input.some(x => input.length > 0)) {

        if (myArr[count] <= input[0]) {
            myArr.push(input[0])
            input.shift();
            count++;
        } else {
            input.shift(input[0])
        }
    }
    myArr.forEach(item => console.log(item))
}

<<<<<<< HEAD

solve([1, 3, 8, 4, 10, 12, 3, 2, 24])
=======
solve([1, 3, 8, 4, 10, 12, 3, 2, 24])
>>>>>>> fab08f4a115a2d6a26780ca2efd9c255ba32bbf2
