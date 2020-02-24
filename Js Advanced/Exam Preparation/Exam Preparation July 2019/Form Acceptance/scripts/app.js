function acceptance() {

	let warehouse = document.getElementById('warehouse')

	let addIt = document.getElementById("acceptance")

	addIt.addEventListener('click', () => {

		let company = document.getElementsByTagName('input')[0].value
		let product = document.getElementsByTagName('input')[1].value
		let quantity = Number(document.getElementsByTagName('input')[2].value)
		let scrape = Number(document.getElementsByTagName('input')[3].value)

		if (company !== '' && product !== '' && quantity !== NaN && scrape !== NaN && quantity - scrape > 0) {

			let div = document.createElement('div')
			let p = document.createElement('p')

			let outOfStockButton = document.createElement('button');
			outOfStockButton.textContent = `Out of stock`
			outOfStockButton.type = 'button'

			p.textContent = `[${company}] ${product} - ${quantity - scrape} pieces`

			div.appendChild(p);
			div.appendChild(outOfStockButton);
			warehouse.appendChild(div);

			document.getElementsByTagName('input')[0].value = '';
			document.getElementsByTagName('input')[1].value = '';
			document.getElementsByTagName('input')[2].value = '';
			document.getElementsByTagName('input')[3].value = '';

			outOfStockButton.addEventListener('click', () => {

					warehouse.removeChild(div)
			})

		}
	})

}