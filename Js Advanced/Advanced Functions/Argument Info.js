function solve(...args) {

    const obj = {};

    for (const argument of args) {

        console.log(`${typeof (argument)}: ${argument} `)

        if (!obj.hasOwnProperty(typeof (argument))) {
            obj[typeof (argument)] = 0;
        }
        obj[typeof (argument)]++;
    }
    Object.entries(obj).sort((a, b) => b[1] - a[1]).forEach(element => {
        console.log(`${element[0]} = ${element[1]}`)
    });
}

solve('cat', 42, function () { console.log('Hello world!'); });