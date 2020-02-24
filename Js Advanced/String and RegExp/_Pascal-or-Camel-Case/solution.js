function solve() {

  let text = document.getElementById('text').value;
  let convention = document.getElementById('naming-convention').value;
  let result = document.getElementById('result');

  let input = text.toLowerCase().split(' ');
  let output = '';

  if (convention === 'Camel Case') {

    output += input[0]
    for (let i = 1; i < input.length; i++) {
      output += input[i].charAt(0).toUpperCase() + input[i].substring(1)
    }

  } else if (convention === 'Pascal Case') {
    output += input[0].charAt(0).toUpperCase() + input[0].substring(1)
    for (let i = 1; i < input.length; i++) {
      output += input[i].charAt(0).toUpperCase() + input[i].substring(1);
    }

  } else {
    output = 'Error!'
  }
  result.innerHTML = output

}