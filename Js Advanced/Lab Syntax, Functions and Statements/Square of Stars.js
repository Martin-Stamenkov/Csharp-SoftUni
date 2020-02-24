function solve(n){
let result = '';

    if(n != null){       
    for (let i = 0; i < n; i++) {

        for (let j = 0; j < n; j++) {
           result +='* '; 
        }
        result += '\n'
      }
      console.log(result)
    }
    else{
        for (let i = 0; i < 5; i++) {

            for (let j = 0; j < 5; j++) {
               result +='* '; 
            }
            result += '\n'
          }
          console.log(result) 
    }
}
//solve(5);