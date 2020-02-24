function solve(input) {

    let data = input.reduce((acc, incomes, i, arr) => {
        if (i % 2 == 0) {
            let town = input[i];
            if (!acc[town]) {
                acc[town] = 0;
            }
        } else {
            let income = input[i];
            acc[arr[i - 1]] += +income

        }
        return acc;

    }, {})
    console.log(JSON.stringify(data))

}
solve(['Sofia',
'20',
'Varna',
'3',
'sofia',
'5',
'varna',
'4']
)