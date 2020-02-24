function solve() {

  let input = document.getElementById("input").innerHTML.split('.').filter(x => x !== '');
  let output = document.getElementById("output")
  let currentSentence = '';

  for (let i = 0; i < input.length; i++) {
    currentSentence += input[i] += '.';

    if ((i + 1) % 3 === 0 || i === input.length - 1) {
      let paragraph = document.createElement("p")
      paragraph.innerHTML = currentSentence;
      currentSentence = '';
      output.appendChild(paragraph);
    }

  }

}