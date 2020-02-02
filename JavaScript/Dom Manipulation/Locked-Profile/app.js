function lockedProfile() {

    let users = document.getElementsByClassName('profile');

    let buttons = document.getElementsByTagName('button')


    for (const button of buttons) {

        button.addEventListener('click', () => {
            let user = button.parentNode.children[9]
            let value = user.id.split('HiddenFields')[0];


           let lock = document.querySelector(`input[name ="${value + 'Locked'}"]`);
           console.log(lock)
               if (!lock.checked && button.innerHTML ==='Show more') {
                   user.style.display = 'block'
                   button.innerHTML = 'Hide it'
                } else if(!lock.checked && button.innerHTML === 'Hide it'){
                    user.style.display = 'none'
                    button.innerHTML ='Show more'
                }
        })
    }

}