function solve() {
   let body = document.getElementsByTagName('tbody')[0]

   body.addEventListener('click', (e) => {
         let currentRow = e.target.parentElement;

         if (currentRow.style.background === '') {

            Array.from(currentRow.parentElement.children).forEach(element => element.style.background = '');
            currentRow.style.background = "#413f5e";

         } else {
            currentRow.style.background = "";

         }
      });
}
