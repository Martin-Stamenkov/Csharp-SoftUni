function solve() {

    let fields = document.getElementsByTagName('input');

    let totalProfit = document.getElementsByTagName('h1')[1];
    let profit = 0;

    let sections = document.querySelectorAll('div[class="bookShelf"]');
    let oldBooks = sections[0];
    let newBooks = sections[1];

    let addButton = document.getElementsByTagName('button')[0];

    addButton.addEventListener('click', (e) => {

        e.preventDefault()

        let title = fields[0].value;
        let year = fields[1].value;
        let price = Number(fields[2].value);

        if (title !== '' && year > 0 && price > 0) {

            let div = document.createElement('div');
            div.classList.add('book')

            let p = document.createElement('p')
            p.textContent = `${title} [${year}]`
            div.appendChild(p);

            let buttonBuy = document.createElement('button')
            let buttonMove = document.createElement('button')

            div.appendChild(buttonBuy);

            if (year >= 2000) {
                newBooks.appendChild(div);
                div.appendChild(buttonMove);

            } else {
                oldBooks.appendChild(div);
                price -= price * 0.15
            }
            buttonBuy.innerHTML = `Buy it only for ${price.toFixed(2)} BGN`
            buttonMove.innerHTML = `Move to old section`;

            buttonBuy.addEventListener('click', () => {

                profit += price
                totalProfit.innerHTML = `Total Store Profit: ${profit.toFixed(2)} BGN`;
                if (year >= 2000) {
                    newBooks.removeChild(div);
                } else {
                    oldBooks.removeChild(div);

                }
            })
            buttonMove.addEventListener('click', () => {
                price -= price * 0.15
                buttonBuy.innerHTML = `Buy it only for ${price.toFixed(2)} BGN`
                div.removeChild(buttonMove)
                oldBooks.appendChild(div);
                buttonBuy.addEventListener('click', () => {
                    oldBooks.removeChild(div)
                })

            })

        }


    })

}