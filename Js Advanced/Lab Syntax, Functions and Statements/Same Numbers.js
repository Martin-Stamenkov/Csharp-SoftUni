function solve(n) {
    let totalSum = 0;

    let inputAsArray = [n].toString().split('')
    
    inputAsArray.forEach(element => {
        totalSum+=parseInt(element);
    });
    let isTrue = true;

    for (let i = 0; i < inputAsArray.length - 1; i++) {
        if (inputAsArray[i] !== inputAsArray[i + 1]) {
            isTrue = false;
            break;
        }

    }
    console.log(isTrue);
    console.log(totalSum);

}
solve(1234)