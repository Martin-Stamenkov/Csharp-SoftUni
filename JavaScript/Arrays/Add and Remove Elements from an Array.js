function solve(input) {

    let initialValue = 1;
    const myArray = [];

    for (let i = 0; i < input.length; i++) {

        if (input[i] === 'add') {
            myArray.push(initialValue);
        }
        else if (input[i] === 'remove') {
            myArray.pop();
        }
        initialValue++;
    }
    if (myArray.some(x => myArray.length > 0)) {
        myArray.forEach(item => console.log(item));
    }
    else {
        console.log('Empty');
    }
}
solve(['add', 'add', 'remove', 'add', 'add'])