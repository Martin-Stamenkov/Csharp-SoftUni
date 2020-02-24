function solve(num1, num2) {

    while (true) {

        let temporary = num1 % num2;
        num1 = num2;
        num2 = temporary;

        if (temporary == 0) {
            break;
        }
    }
    console.log(num1)
}
(2154, 458);