(() => {
    String.prototype.ensureStart = function (str) {
        if (!this.startsWith(str)) {
          return`${str}${this}`
        }
        return this.toString()
    }
    String.prototype.ensureEnd = function (str) {
        if (!this.endsWith(str)) {
           return `${this}${str}`
        }
        return this.toString()
    }
    String.prototype.isEmpty = function () {
        if (this.toString().length === 0) {
            return true
        }
        return false
    }
    String.prototype.truncate = function (n) {
        if (n < 4) {
            return '.'.repeat(n)
        }
        else if (this.length <= n) {
            return this.toString();
        } else if (this.length > n) {
            let lastSpace = this.substr(0, n - 2).lastIndexOf(' ')
            if (lastSpace !== -1) {
                return this.substr(0, lastSpace).concat('...');
            } else {
                return this.substr(0, n - 3).concat('...')
            }
        }
    }
    String.format = function (str, ...params) {
        for (let i = 0; i < params.length; i++) {
            str = str.replace(`{${i}}`, params[i])
        }
        return str;
    }
    console.log("test".ensureStart("myTest"))
    console.log("test".ensureEnd("myTest1"))
    console.log("test".format('jumps {0} {1}',
        'dog', 'fox'))

})();