function solve() {
  let input = document.getElementById('text').value

  let result = document.getElementById('result');

  let split = input.split(' ');

  let numbers = /\d+/
  let words = /[a-zA-Z]+|[%@!]/
  let output = ''
  
  for (const element of split) {
    if (element.match(numbers)) {
      
      let number = Number(element)
      output += String.fromCharCode(number)
      
    } else if (element.match(words)) {
      
      let charToNum = []
      for (let i = 0; i < element.length; i++) {
        charToNum.push(element[i].charCodeAt(0))
      }
      let p = document.createElement('p')
      p.innerHTML = (charToNum.join(' '));
      result.appendChild(p);
    }

  }
  let p = document.createElement('p')
  p.innerHTML = output;
  result.appendChild(p)

}