function solve(text) {

    let regex = /\w+/g;
    let result = text.matchAll(regex);
    result = Array.from(result);
    let toUpper = result.join(', ').toUpperCase();


    console.log(toUpper);
}
//solve('Hi, how are you?');