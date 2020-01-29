function solve() {
    return {
        add: (a, b) => ([a[0] + b[0], a[1] + b[1]]),
        multiply: (a, scalar) => ([a[0] * scalar, a[1] * scalar]),
        length: (a) => Math.sqrt(a[0] * a[0] + a[1] * a[1]),
        dot: (a, b) => (a[0] * a[1] + b[0] * b[1]),
        cross: (a, b) => (a[0] * b[1] - a[1] * b[0])

    };
};
let solution = solve()
console.log(solution.add([1, 1], [1, 0]))
console.log(solution.multiply([3.5, -2], 2))
console.log(solution.length([3, -4]))
console.log(solution.dot([2, 3], [2, -1]))
console.log(solution.cross([3, 7], [1, 0]))