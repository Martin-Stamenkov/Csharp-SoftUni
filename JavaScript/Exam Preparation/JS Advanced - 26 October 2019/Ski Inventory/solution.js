function solve() {

   let products = document.getElementById('products').children[1];
   let myProducts = document.getElementById('myProducts').children[1];
   let totalPrice = document.querySelector("body > h1:nth-child(4)");

   let inputProduct = document.getElementsByTagName('input');
   let inputFilter = inputProduct[0];
   let name = inputProduct[1]
   let quantity = inputProduct[2]
   let price = inputProduct[3]

   let buttons = document.getElementsByTagName('button');
   let filterButton = buttons[0];
   let addButton = buttons[1];
   let buyButton = buttons[2];

   addButton.addEventListener('click', (e) => {
      e.preventDefault()

      let li = document.createElement('li');
      let span = document.createElement('span');
      let strongQuantity = document.createElement('strong');
      let div = document.createElement('div');
      let strongPrice = document.createElement('strong');
      let buttonAddToClienList = document.createElement('button');

      span.innerHTML = name.value;
      strongQuantity.innerHTML = 'Available: ' + Number(quantity.value);

      strongPrice.innerHTML = Number(price.value).toFixed(2);
      buttonAddToClienList.innerHTML = 'Add to client\`s List'

      div.appendChild(strongPrice);
      div.appendChild(buttonAddToClienList);

      li.appendChild(span);
      li.appendChild(strongQuantity);
      li.appendChild(div);

      products.appendChild(li)

      buttonAddToClienList.addEventListener('click', (e) => {
         let currentProduct = e.target.parentNode.parentNode
         let name = currentProduct.children[0].innerHTML;
         let quantity = Number(currentProduct.children[1].innerHTML.split(' ')[1]);
         let price = Number(e.target.parentNode.children[0].innerHTML)

         totalPrice.innerHTML = `Total Price: ${(Number(totalPrice.innerHTML.split(' ')[2]) + price).toFixed(2)}`
         currentProduct.children[1].innerHTML = `Available: ${Number(quantity - 1)}`

         if (quantity - 1 === 0) {
            currentProduct.remove()
         }

         let liMyProducts = document.createElement('li')
         liMyProducts.innerHTML = name
         let strongMyProducts = document.createElement('strong');
         strongMyProducts.innerHTML = price

         liMyProducts.appendChild(strongMyProducts)
         myProducts.appendChild(liMyProducts)
      })
   })

   buyButton.addEventListener('click', () => {

      totalPrice.innerHTML = `Total Price: 00.00`
      myProducts.remove()
   })

   filterButton.addEventListener('click', (e) => {
      e.preventDefault()

      for (const product of Array.from(products.children)) {
         if (!product.children[0].innerHTML.toLowerCase().includes(inputFilter.value.toLowerCase())) {
            product.style.display = 'none'
         } else {
            product.style.display = 'block'

         }
      }
   })

}

