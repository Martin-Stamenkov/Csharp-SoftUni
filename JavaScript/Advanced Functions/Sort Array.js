function solve(array, criteria) {
    if (criteria === 'asc') {
        return array.sort((a, b) => a - b)
    }
    return array.sort((a, b) => b - a)

}
let sortArray = solve([14, 7, 17, 6, 8], 'asc')
console.log(sortArray)