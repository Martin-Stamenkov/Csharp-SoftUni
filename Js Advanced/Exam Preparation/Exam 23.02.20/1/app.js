function solve() {

   let inputFields = document.getElementsByTagName('input');
   let author = inputFields[0];
   let title = inputFields[1];
   let category = inputFields[2];
   let textarea = document.getElementById('content')

   let create = document.getElementsByTagName('button')[0]

   let sections = document.getElementsByTagName('section')

   let articles = sections[1];
   let archive = sections[3].children[1];

   create.addEventListener('click', (e) => {
      e.preventDefault()

      if (author.value !== '' && title.value !== '' && category.value !== '' && textarea.value !== '') {

         let currArticle = document.createElement('article');

         let h1Title = document.createElement('h1');
         h1Title.innerHTML = title.value;
         currArticle.appendChild(h1Title);

         let pCategory = document.createElement('p');
         pCategory.innerHTML = 'Category: '

         let strongCategory = document.createElement('strong')
         strongCategory.innerHTML = category.value;
         pCategory.appendChild(strongCategory);
         currArticle.appendChild(pCategory);

         let pCreator = document.createElement('p');
         pCreator.innerHTML = 'Creator: '

         let strongCreator = document.createElement('strong');
         strongCreator.innerHTML = author.value;
         pCreator.appendChild(strongCreator);
         currArticle.appendChild(pCreator)

         let pTextArea = document.createElement('p');
         pTextArea.innerHTML = textarea.value;
         currArticle.appendChild(pTextArea);

         let div = document.createElement('div');
         div.classList.add('buttons')

         let deleteButton = document.createElement('button')
         deleteButton.classList.add('btn');
         deleteButton.classList.add('delete');
         deleteButton.innerHTML = 'Delete';
         div.appendChild(deleteButton);

         let archiveButton = document.createElement('button');
         archiveButton.classList.add('btn');
         archiveButton.classList.add('archive');
         archiveButton.innerHTML = 'Archive';
         div.appendChild(archiveButton);

         currArticle.appendChild(div);
         articles.appendChild(currArticle);

         deleteButton.addEventListener('click', () => {

            articles.removeChild(currArticle);
            // author.value = ''
            // title.value = ''
            // category.value = ''
            // textarea.value = ''

         })
         archiveButton.addEventListener('click', (e) => {
            e.preventDefault()

            let li = document.createElement('li');
            li.innerHTML = h1Title.innerHTML
            archive.appendChild(li)
            let lis = archive.getElementsByTagName('li')
            let ordered = [];

            for (let i = 0; i < lis.length; i++) {
               ordered.push(lis[i].innerHTML);
            }
            ordered.sort((a, b) => {
               return a.toLowerCase().localeCompare(b.toLowerCase())
            });;
            for (let i = 0; i < lis.length; i++) {
               lis[i].innerHTML = ordered[i];

            }

            articles.removeChild(currArticle)
         })

      }

   })
}
