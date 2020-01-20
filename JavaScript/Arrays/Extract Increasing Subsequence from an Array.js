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


solve([1, 3, 8, 4, 10, 12, 3, 2, 24])