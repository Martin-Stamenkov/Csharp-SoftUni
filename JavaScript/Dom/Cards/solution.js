function solve() {

   let result = document.querySelector("#result").children
   let history = document.getElementById('history')
   console.log(history)
   let firstPlayer = '';
   let secondPlayer = '';

   let cards = document.getElementsByClassName("cards")[0]
   cards.addEventListener('click', (e) => {
      let currentPlayer = e.target.parentElement.id;

      if (currentPlayer === 'player1Div') {
         firstPlayer = e.target
         e.target.src = 'images/whiteCard.jpg'
         result[0].innerHTML = e.target.name
      } else {
         secondPlayer = e.target
         e.target.src = 'images/whiteCard.jpg'
         result[2].innerHTML = e.target.name

      }
      if (firstPlayer != '' && secondPlayer != '') {

         if (+firstPlayer.name > +secondPlayer.name) {
            firstPlayer.style.border = "2px solid green"
            secondPlayer.style.border = "2px solid red"
         } else {
            firstPlayer.style.border = "2px solid red"
            secondPlayer.style.border = "2px solid green"
         }
         result[0].innerHTML = ''
         result[2].innerHTML = ''
         history.innerHTML += `[${firstPlayer.name} vs ${secondPlayer.name}] `
         firstPlayer = '';
         secondPlayer = '';
      }
   })

}