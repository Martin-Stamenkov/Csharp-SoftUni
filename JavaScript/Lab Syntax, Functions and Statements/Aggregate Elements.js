function solve(elements){
    aggregate(elements,0,(a,b) => a + b);
    aggregate(elements,0.,(a,b) => a + 1/b);
    aggregate(elements,'',(a,b) => a + b);

    function aggregate(array , initalVal , func){
        let value = initalVal;

        for (let index = 0; index < array.length; index++) {
            value = func(value,array[index])
        }
        console.log(value)
    }
}
solve([1,2,3])