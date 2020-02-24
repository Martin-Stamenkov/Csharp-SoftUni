function solve() {

    let input = document.querySelector("#expressionOutput");

    let output = document.querySelector("#resultOutput");

    let buttons = document.querySelector("#calculator > div.keys");

    let clear = document.querySelector("#calculator > div.top > button")

    console.log(buttons)

    const operator = ['+', '-', '*', '/'];

    const operations = {
        '+': (num1, num2) => Number(num1) + Number(num2),
        '-': (num1, num2) => Number(num1) - Number(num2),
        '*': (num1, num2) => Number(num1) * Number(num2),
        '/': (num1, num2) => Number(num1) / Number(num2)

    }

    buttons.addEventListener('click', (e) => {

        clear.addEventListener('click', () => {

            input.innerHTML = '';
            output.innerHTML = '';

        })


        let value = e.target.value;

        if (!value) {
            return;
        }
        if (value === '=') {
            let params = input.innerHTML.split(' ')

            if (params[2]) {

                output.innerHTML = operations[params[1]](params[0], params[2])
                return;
            }
            output.innerHTML = 'NaN';
            return;

        }

        if (operator.includes(value)) {
            input.innerHTML += ` ${value} `

            return;
        }
        input.innerHTML += value
    })
}