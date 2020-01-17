function solve(input){

    let step = (Number)(input.pop());
    console.log(input[0]);
    for (let i = step; i < input.length; i+=step) {
        console.log(input[i]);
    } 
}
solve(['5', '20', '31', '4', '20', '2']);