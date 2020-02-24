function solve(input) {

   let parsedData = input.map(x => JSON.parse(x));

   let createTable = content => `<table>${content}\n</table>`
   let createTableRow = content => `\n    <tr>${content}\n    </tr>`
   let createTableData = content => `\n      <td>${content}</td>`

   let result = parsedData.reduce((accRow, row) => {
      let tdForPerson = Object.values(row).reduce((accData, td) => {
         return accData += createTableData(td);
      }, '')
      return accRow + createTableRow(tdForPerson);
   }, '')

   return createTable(result);


}
console.log(solve(['{"name":"Pesho","position":"Promenliva","salary":100000}',
   '{"name":"Teo","position":"Lecturer","salary":1000}',
   '{"name":"Georgi","position":"Lecturer","salary":1000}']));