function solve([x1, y1, x2, y2]) {

    function validator(x1, y1, x2, y2) {

        let a = x1 - x2;
        let b = y1 - y2;
        let distance = Math.sqrt(a * a + b * b);

        if (distance % 1 == 0) {
            console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`)

        } else {
            console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`)
        }
    }
    validator(x1, y1, 0, 0);
    validator(x2, y2, 0, 0);
    validator(x1, y1, x2, y2);
}
solve([3, 0, 0, 4])
