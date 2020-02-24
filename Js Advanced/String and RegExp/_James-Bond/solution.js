function solve() {

    let [key, ...line] = JSON.parse(document.getElementById('array').value)
    let result = document.getElementById('result')

    let message = new RegExp(`${key}[ ]+([A-Z!$#%\$]{8,})([\., ]|$)`, 'gmi')

    for (const data of line) {

        let replacedLine = data;
        if (data.match(message)) {
            let matches = data.match(message)
                .map(x => x.split(' ')[1])
                .filter(x => x.toUpperCase())
                .map(x => {
                    let parsedWord = x.replace(/!/g, 1)
                        .replace(/%/g, 2)
                        .replace(/#/g, 3)
                        .replace(/\$/g, 4)
                        .toLowerCase()

                    replacedLine = replacedLine.replace(x, parsedWord)
                })

        }
        let p = document.createElement('p');
        p.innerHTML = replacedLine;
        result.appendChild(p);
    }


}
