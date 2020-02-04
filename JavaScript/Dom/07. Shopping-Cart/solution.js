function solve() {

   let textarea = document.getElementsByTagName('textarea')[0]

   let addButtons = document.getElementsByClassName('add-product');

   const products = []
   let totalPrice = 0;

   Array.from(addButtons).forEach(b => b.addEventListener('click', function (e) {

      let price = e.target.parentNode.nextElementSibling.innerHTML
      totalPrice += Number(price);
      let name = e.target.parentNode.previousElementSibling.childNodes[1].innerHTML

      if (!products.includes(name)) {
         products.push(name)

      }

      textarea.innerHTML += `Added ${name} for ${price} to the cart.\n`

   }))
   document.getElementsByClassName('checkout')[0].addEventListener('click', () => {

      textarea.innerHTML += `You bought ${products.join(', ')} for ${totalPrice.toFixed(2)}.`
        Array.from(document.getElementsByTagName('button')).forEach(b =>b.disabled = true)
   })

}