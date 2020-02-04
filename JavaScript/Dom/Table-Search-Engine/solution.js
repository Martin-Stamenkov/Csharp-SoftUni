function solve() {

   let data = document.querySelectorAll("tbody > tr");

   let button = document.getElementById('searchBtn')

   let searchField = document.getElementById('searchField')

   button.addEventListener('click', () => {

      console.log(data)
      for (let i = 0; i < data.length; i++) {

         let cells = data[i].querySelectorAll('td')

         for (let j = 0; j < cells.length; j++) {

            if (cells[j].innerHTML.includes(searchField.value)) {
               data[i].className = 'select';
               break;

            }

         }

      }

   });
}