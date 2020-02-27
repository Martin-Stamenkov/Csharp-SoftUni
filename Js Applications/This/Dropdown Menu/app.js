function solve() {
    let button = document.querySelector("#dropdown");

    let box = document.querySelector("#box");
    let dropdownUl = document.querySelector("#dropdown-ul");

    button.addEventListener('click', () => {
        if (dropdownUl.style.display === 'none' || dropdownUl.style.display === '') {
            dropdownUl.style.display = 'block'

            let elements = dropdownUl.children
            Array.from(elements).forEach(li => {
                li.addEventListener('click', () => {
                    box.style.backgroundColor = li.textContent
                    box.style.color = 'black'
                    
                })
                
            });
        }
        else{
            dropdownUl.style.display = 'none'
            box.style.backgroundColor = 'black'
            box.style.color = 'white'

        }
    })
}