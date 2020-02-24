function solve(input) {

     let output = Array.from( new Set(input)).sort((a, b) => {
        if (a.length - b.length) {
            return a.length - b.length
        }
        return a.localeCompare(b);
    })

    console.log(output.join('\n'))
}
solve(['Ashton',
    'Kutcher',
    'Ariel',
    'Lilly',
    'Keyden',
    'Aizen',
    'Billy',
    'Braston']);