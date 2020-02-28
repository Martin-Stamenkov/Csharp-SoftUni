(function () {

    Array.prototype.last = function () {
        return this[this.length - 1];
    }

    Array.prototype.skip = function (n) {

        let newCollection = [];
        for (let i = n; i < this.length; i++) {
            newCollection.push(this[i]);
        }
        return newCollection
    }

    Array.prototype.take = function (n) {
        let newCollection = [];
        for (let i = 0; i < n; i++) {
            newCollection.push(this[i])
        }
        return newCollection
    }

    Array.prototype.sum = function () {
        return this.reduce((acc, curr) => acc + curr)
    }

    Array.prototype.average = function () {
        return this.reduce((acc, curr, i, arr) => acc + curr) / this.length
    }

    let myArray = [1, 2, 3]
    console.log(myArray.average())

})();