function solve(input) {

    let data = input.reduce((acc, line) => {
        let [town, population] = line.split('<->').map(x => x.trim());
        if (!acc[town]) {
            acc[town] = 0; 
        }
        acc[town] += +population;

return acc;
    }, {});
  for (const key in data) {
     console.log(`${key} : ${data[key]}`)
          
      }
  }


solve(['Istanbul <-> 100000',
    'Honk Kong <-> 2100004',
    'Jerusalem <-> 2352344',
    'Mexico City <-> 23401925',
    'Istanbul <-> 1000']);