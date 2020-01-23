function solve(input = []){

    let towns  = [];
    let regex = /\s*\|\s*/;

    for (let item of input.splice(1)) {
        let tokens = item.split(regex)
        let obj = { Town: tokens[1], Latitude: +(+(tokens[2])).toFixed(2), Longitude: +(+(tokens[3])).toFixed(2)};
        towns.push(obj);
    }
    console.log(JSON.stringify(towns))  
    
}
solve(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |'])