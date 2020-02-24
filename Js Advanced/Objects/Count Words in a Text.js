function solve(input) {

    let validWords = input[0].match(/\w+/g);
    let data = validWords.reduce((acc, curr) => {
        if (acc[curr]) {
            acc[curr]++
        } else {
            acc[curr] = 1;
        }
        return acc;

    }, {})
    console.log(JSON.stringify(data))

}
solve(['JS devs use Node.js for server-side JS.-- JS for devs'])