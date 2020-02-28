function solve(data) {

    return JSON.parse(data).reduce((acc, curr) => {
        Object.assign(acc, curr);
        return acc;
    }, {})
}

console.log(solve(`[{"canMove": true},{"canMove":true, "doors": 4},{"capacity": 5}]`))