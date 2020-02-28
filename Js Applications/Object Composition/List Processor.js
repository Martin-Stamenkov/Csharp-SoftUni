function solve(data) {
    function allCommands() {

        let arr = [];

        function add(str) {
            arr.push(str)
        }
        function remove(str) {
            arr = arr.filter(x => x !== str)
        }
        function print() {
            console.log(arr.join(','))
        }
        return { add, remove, print }
    }
    let commands = allCommands()
         data.forEach(element => {
        let [command , type] = element.split(' ');
        return commands[command](type)
    });
}
solve(['add hello', 'add again', 'remove hello', 'add again', 'print'])