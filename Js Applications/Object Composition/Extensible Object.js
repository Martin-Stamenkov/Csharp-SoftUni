function solve() {

    let myObj = {
        extend: (template) => {
            Object.keys(template).forEach((key) => {
                if (typeof template[key] === 'function') {
                    Object.getPrototypeOf(this)[key] = template[key]
                } else {
                    this[key] = template[key]
                }
            })

        }

    }
    myObj.extend({
        __proto__: {
            extensionMethod: function () { }
        },
        extend: function () { },
        extensionProperty: 'someString'
    
    });
    return myObj
    
}

