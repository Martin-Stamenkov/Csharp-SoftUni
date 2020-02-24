function solve(input) {

    let rotations = input.pop();

    for (let i = 0; i < rotations % input.length; i++) {
        let lastElement = input.pop();
        input.unshift(lastElement);
    }

    console.log(input.join(' '));
}
solve(['Banana', 'Orange', 'Coconut', 'Apple', '15'])