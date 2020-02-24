function solve() {

    let text = document.getElementById('text').value
    let number = Number(document.getElementById('number').value)
    let result = document.getElementById('result')

    const separatedString = []
    if (text.length % number === 0) {

        for (let i = 0; i < text.length; i += number) {
            separatedString.push(text.substring(i, i + number))
        }
    } else {
        let symbolCount = 0
        let length = text.length;
        let index = 0;

        while (length % number !== 0) {
            length %= number;
            length++;
            symbolCount++;
        }
        for (let i = 0; i < symbolCount; i++) {
            text += text[index++];
        }
        for (let i = 0; i < text.length; i += number) {
            separatedString.push(text.substring(i, i +  number))
        }
    }
    result.innerHTML = separatedString.join(' ');

}