function solve(input) {

    let leftDiagonal = 0;
    let rightDiagonal = 0;

    for (let row = 0; row < input.length; row++) {
        leftDiagonal+=input[row][row];
        rightDiagonal+=input[row][input.length - 1 - row]
    }
    console.log(leftDiagonal + " " + rightDiagonal)
}  
solve
([[3, 5, 17],
[-1, 7, 14],
[1, -8, 89]]);