function addItem() {
    let textbox = document.querySelector("#newItemText")
    let items = document.querySelector("#items");
    let li = document.createElement('li');

    li.innerHTML = textbox.value;
    items.appendChild(li)
    textbox.value = '';
}