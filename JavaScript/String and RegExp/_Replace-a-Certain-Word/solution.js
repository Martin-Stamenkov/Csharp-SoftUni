function solve() {
    let word = document.getElementById('word').value;
    let text = JSON.parse(document.getElementById('text').value);
    let result = document.getElementById('result');

    let changingWord = text[0].split(' ')[2];
    let regex = new RegExp(`${changingWord}`,'gi')
    let newWords = [];
    for (let index = 0; index < text.length; index++) {
        let currentText = text[index].replace(regex,word);
        newWords.push(currentText);

    }
    for (const element of newWords) {
        let p = document.createElement('p')
        p.innerHTML = element
        result.appendChild(p)
        
    }
}