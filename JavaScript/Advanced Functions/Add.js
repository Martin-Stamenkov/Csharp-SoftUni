 function solution(a) {
        return function(b){
            return a + b;
        };
}
var add5 = solution(7);
console.log(add5(2));
console.log(add5(3));
