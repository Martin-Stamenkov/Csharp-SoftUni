function solution() {

    let input = document.getElementsByTagName('input')[0];
    let button = document.getElementsByTagName('button')[0];
    let sections = document.getElementsByClassName('card');

    let listOfGifts = sections[1].childNodes[3];
    let sendGifts = sections[2].childNodes[3];
    let discardGifts = sections[3].childNodes[3];

    button.addEventListener('click', () => {

        let gift = input.value;

        if (input.value !== '') {
            let li = document.createElement('li');
            li.classList.add('gift')
            li.innerHTML = gift

            let sendButton = document.createElement('button');
            sendButton.id = 'sendButton';
            sendButton.innerHTML = 'Send';

            let discardButton = document.createElement('button');
            discardButton.id = 'discardButton';
            discardButton.innerHTML = 'Discard';

            li.appendChild(sendButton)
            li.appendChild(discardButton)
            listOfGifts.appendChild(li)

            let lis = listOfGifts.getElementsByTagName('li')
            let ordered = [];

            for (let i = 0; i < lis.length; i++) {
                ordered.push(lis[i].innerHTML);
            }
            ordered.sort();

            for (let i = 0; i < lis.length; i++) {
                lis[i].innerHTML = ordered[i];
            }

            let buttons = document.getElementsByTagName('button');
            for (const button of buttons) {

                if (button.innerText === 'Send') {

                    button.addEventListener('click', (e) => {
                        let currentGift = e.target.parentNode
                        console.log(currentGift)
                        currentGift.children[0].remove();
                        currentGift.children[0].remove();

                        sendGifts.appendChild(currentGift)

                    })
                } else if (button.innerText === 'Discard') {

                    button.addEventListener('click', (e) => {
                        let currentGift = e.target.parentNode
                        currentGift.children[0].remove();
                        currentGift.children[0].remove();

                        discardGifts.appendChild(currentGift)

                    })
                }

            }
            input.value = ''
        }


    })
}