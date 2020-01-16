function solve(input){

    let myArray = [];
    for (let i = 0; i < 2; i++) {
        
        let minElement = Math.min(...input);
        myArray.push(minElement);
        let index = input.indexOf(minElement);
        input.splice(index , 1);
    }

    console.log(myArray.join(' '));
}
solve([3, 0, 10, 4, 7, 3]);