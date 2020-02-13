function solve() {

	let input = document.getElementById('input').value;

	let resultOutput = document.getElementById('resultOutput');

	let num = input.split('').map(Number).reduce((call, i) => call + i);

	while (num > 9) {
		num = num.toString().split('').map(Number).reduce((acc, i) => acc + i)
	}
	let parsedinput = input.slice(num, input.length - num)

	let eachSegment = [];
	let regex = /[A-Za-z ]+/;


	for (let i = 0; i < Math.ceil(parsedinput.length / 8); i++) {

		eachSegment.push(String.fromCharCode(parseInt(parsedinput.slice(i * 8, (i + 1) * 8), 2)))
	}

	resultOutput.innerHTML = eachSegment.filter(x => x.match(regex)).join('')

}