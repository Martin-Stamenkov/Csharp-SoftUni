function solve() {

    let string = document.getElementById('string').value;
    let text = document.getElementById('text').value;
    let result = document.getElementById('result');

    let saveMessage = text.match(`${string}(.*)${string}`)[1];
    let saveCoordinates = /(?<directions>east|north).*?(?<coordinates>[0-9]{2})[^,]*,[^,]*?(?<decimals>[0-9]{6})/gmi

    let north;
    let east;

    let temp = saveCoordinates.exec(text)

    while (temp) {

        if (temp[1].toLowerCase()=== 'north') {
            north = `${temp[2]}.${temp[3]}`;
        } else {
            east = `${temp[2]}.${temp[3]}`;
        }

        temp = saveCoordinates.exec(text)
    }

    result.innerHTML = `
    <p>${north} N</p> 
    <p>${east} E</p> 
    <p>Message: ${saveMessage}</p> `;

}
