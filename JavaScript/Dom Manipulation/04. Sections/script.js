function create(words) {

   let body = document.querySelector("#content");

   for (const word of words) {
      let paragraph = document.createElement('p');
      paragraph.innerHTML = word;
      paragraph.style.display = 'none'



      let div = document.createElement('div');
      div.appendChild(paragraph)
      div.addEventListener('click', () => {
         paragraph.style.display = 'block';
      })
      
      body.appendChild(div)

   }
}