function subtract() {
    let firstNum = document.querySelector("#firstNumber");

    let secondNum = document.querySelector("#secondNumber");

    let output = document.querySelector("#result");

    output.textContent = firstNum.value - secondNum.value;
}