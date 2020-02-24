function solve(r){
    let result;
    let inputType = typeof(r);

    if(inputType !== 'number'){
        console.log(`We can not calculate the circle area, because we receive a ${typeof(r)}.`)
    }
    else{
        result = Math.PI * Math.pow(r,2)
        console.log(result.toFixed(2))
    }
}
solve(5)