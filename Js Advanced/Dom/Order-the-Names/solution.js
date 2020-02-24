function solve() {

    let input = document.querySelector("#exercise > article > input[type=text]");

    let addButton = document.querySelector("#exercise > article > button");

    let dataBase = document.getElementsByTagName('li');

    console.log(dataBase)

    addButton.addEventListener('click', () => {

        let firstLetter = input.value[0].toUpperCase();

        let currentRow = (firstLetter.charCodeAt()) - 65

        let name = firstLetter + input.value.substring(1).toLowerCase();

        input.value = '';

        if (dataBase[currentRow].innerHTML === '') {
            dataBase[currentRow].innerHTML = name;

        } else {
            dataBase[currentRow].innerHTML += ', ' + name

        }


    })

}