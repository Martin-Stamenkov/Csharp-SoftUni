function addItem() {
    let menu = document.querySelector("#menu");

    let text = document.querySelector("#newItemText");

    let value = document.querySelector("#newItemValue")

    let option = document.createElement('option');


    if (text.value.length === 0) {
        return;
    }
    option.innerHTML = text.value;
    option.value = value.value;

    menu.appendChild(option);

    text.value = '';
    value.value = '';

}