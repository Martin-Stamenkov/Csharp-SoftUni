function solve(num1,num2){
    let result = 0;

    let parsedNum1 = Number(num1);
    let parsedNum2 = Number(num2);

    for (let index = parsedNum1; index <= parsedNum2; index++) {
        result += index;
    }
    console.log(result)
}
solve('1','5');