function solve(data) {
    let obj = {
        width: 0,
        height: 0,
        area: function () {
            return this.width * this.height;
        },
        compareTo: function (current) {
            if (this.area() > current.area()) {
                return 1;
            } else if (this.area() < current.area()) {
                return -1;
            } else {
                return 0
            }
        }
    }
    return data.map(([width, height]) =>
        Object.assign(Object.create(obj), {
            width
            , height
        })).sort((a, b) => b.compareTo(a) === 0 ? b.width - a.width : b.compareTo(a))
}
console.log(solve([[1,20],[20,1],[5,3],[5,3]]))