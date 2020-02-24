class List {

    constructor() {
        this.list = []
        this.size = 0;

    }
    
    add(element) {
        this.list.push(element);
        this.list.sort((a, b) => a - b);
        this.size++
    }
    remove(index) {
        if (this.validIndex(index)) {
            
            this.list.splice(index, 1);
            this.list.sort((a, b) => a - b);

            this.size--;
        }
    }
    get(index) {
        if (this.validIndex(index)) {
            return this.list[index];        }
    }
    validIndex(index) {
        return (index < this.list.length && index >= 0)
    }
}
let list = new List();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(6));
list.remove(1);
console.log(list.get(1));
console.log(list.size)