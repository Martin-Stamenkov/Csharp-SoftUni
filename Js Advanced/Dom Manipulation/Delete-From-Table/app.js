function deleteByEmail() {

    let textBox = document.querySelector("body > label > input[type=text]");

    let customers = document.querySelectorAll('#customers tr');

    let result = document.querySelector("#result")

    let shouldBeDeleted = false;

    if (textBox.value.length === 0) {
        return
    }

        for (let i = 0; i < customers.length; i++) {
            if (customers[i].lastElementChild.innerHTML === textBox.value) {

                customers[i].parentElement.removeChild(customers[i])
                result.textContent = 'Deleted.'
                shouldBeDeleted = true;
            }
        }
        if (shouldBeDeleted === false) {

            result.textContent = 'Not found.'

        }

}