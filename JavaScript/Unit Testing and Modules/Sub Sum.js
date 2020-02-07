function solve(arr, startIndex, endIndex) {

    let parsedArr = Array.from(arr).map(x => Number(x));
    let result = 0;

    if (!Array.isArray(arr) || !arr.every(x => typeof (x) === 'number')) {
        return NaN;
    }
    if (startIndex < 0) {
        startIndex = 0;
    }
    if (endIndex > arr.length) {
        endIndex = parsedArr.length - 1
    }
    if (arr.length === 0) {
       return 0;
    } else {
 
        for (let i = startIndex; i <= endIndex; i++) {
            result += parsedArr[i];
        }
        return result;
    }

}
console.log(solve([10, 20, 30, 40, 50, 60], 3, 300))
console.log(solve([1.1, 2.2, 3.3, 4.4, 5.5], -3, 1))
console.log(solve([10, 'twenty', 30, 40], 0, 2))
console.log(solve([], 1, 2))
console.log(solve('text', 0, 2))
console.log(solve([], 0, 0))
