function solve() {

    let input = JSON.parse(document.getElementById('arr').value);
    let output = document.getElementById('result');

    let regex = /(?<name>[A-Z][a-z]* [A-Z][a-z]*) (?<phone>\+359( |-)\d\3\d{3}\3\d{3}) (?<email>[a-z0-9]+@[a-z]+.[a-z]{2,3})/

    let result = []

    for (const data of input) {
        if (data.match(regex)) {

            const temp = regex.exec(data)
            result.push(`Name: ${temp.groups.name}`)
            result.push(`Phone Number: ${temp.groups.phone}`)
            result.push(`Email: ${temp.groups.email}`)
            result.push(`- - -`)

        } else {
            result.push('Invalid data')
            result.push('- - -')
        }
    }

    for (const element of result) {
        let p = document.createElement('p');
        p.innerHTML = element;
        output.appendChild(p)
    }
}