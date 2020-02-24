function solve() {

    let input = document.getElementById("input")

    let selectTo = document.getElementById("selectMenuTo")

    let button = document.querySelector("button")

    let binary = document.createElement("option")
    binary.value = "binary";
    binary.innerHTML = "Binary";
    selectTo.appendChild(binary);

    let hexadecimal = document.createElement("option")
    hexadecimal.value = "hexadecimal";
    hexadecimal.innerHTML = "Hexadecimal"
    selectTo.appendChild(hexadecimal);

    button.addEventListener('click', () => {

        result = 0;
        if (selectTo.value === "binary") {

            result = Number(input.value).toString(2);
        } else {
            result = Number(input.value).toString(16).toUpperCase();
        }

        let inputResult = document.getElementById("result").value = result
    })

}