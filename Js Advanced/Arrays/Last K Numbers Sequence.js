function solve(n, k) {

    let myArray = [];
    myArray.push(1);

    for (let i = 1; i < n; i++) {

        let startIndex = Math.max(0, i - k);
        let currentElement = myArray.slice(startIndex, startIndex + k).reduce((acc, i) => acc + i);
        myArray.push(currentElement);
    }

    console.log(myArray.join(' '));
}
solve(6, 3)