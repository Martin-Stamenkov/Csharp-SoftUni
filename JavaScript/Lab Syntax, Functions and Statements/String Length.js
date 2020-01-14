function solve(arr1,arr2,arr3){

let firstArrgument = arr1.length;
let secondArgument = arr2.length;
let thirdArgument = arr3.length;

let totalLength = firstArrgument+secondArgument+thirdArgument;
let averageLength = Math.floor(totalLength/3)
console.log(totalLength);
console.log(averageLength);
}
solve('chocolate','cake','ice cream');