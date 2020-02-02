function addItem() {

    let textBox = document.querySelector("#newText");

    let items = document.querySelector("#items");

    if (textBox.value.length === 0) {
        return;
    }

    let li = document.createElement('li');
    li.innerHTML = textBox.value + ' ';
    items.appendChild(li)

    let remove = document.createElement('a')
    remove.href = '#';
    remove.innerHTML = '[Delete]';
    li.appendChild(remove)

    textBox.value = '';

    remove.addEventListener('click', () => {
        items.removeChild(li);
    })


}