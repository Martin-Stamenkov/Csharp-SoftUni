function solve(input) {

    let unique = new Set()

    let line = input.reduce((acc, curr) => {

        let words = curr.toLowerCase().match(/\w+/g);
        let uniqueWords = words.reduce((accLine, currLine) => {
            unique.add(currLine);
        },{})

        return acc;
    }, {})
    console.log(Array.from(unique.keys()).join(', '))
}
solve(['Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 'Pellentesque quis hendrerit dui.',
    'Quisque fringilla est urna, vitae efficitur urna vestibulum fringilla.',
    'Vestibulum dolor diam, dignissim quis varius non, fermentum non felis.',
    'Vestibulum ultrices ex massa, sit amet faucibus nunc aliquam ut.',
    'Morbi in ipsum varius, pharetra diam vel, mattis arcu.',
    'Integer ac turpis commodo, varius nulla sed, elementum lectus.',
    'Vivamus turpis dui, malesuada ac turpis dapibus, congue egestas metus.']);