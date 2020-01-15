function solve(data) {
    let dataObject = {};

    for (let i = 0; i < data.length; i += 2) {

        dataObject[data[i]] = +data[i+1];
    }
    console.log(dataObject)
}
solve(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);