function list() {
function chekIndex(arr , index){
    return (index < this.arr.length && index >= 0) 

}

    return {
        arr: [],
        size: 0,
        add: function(el) {
            this.arr.push(el);
            this.arr.sort((a, b) => a - b);
            this.size++
        },
        remove: function(index) {

            if (index < this.arr.length && index >= 0) {

                this.arr.splice(index, 1)
                this.size--

            }
        },
        get: function(index) {
            if (index < this.arr.length && index >= 0) {

                return this.arr[index]

            }
        }
    }

}