let PaymentPackage = require('./Payment Package')
let assert = require('chai').assert;

describe('PaymentPackage', () => {

    it('test constructor', () => {

        let paymentPackage = new PaymentPackage('HR Services', 1500)

        assert.equal(paymentPackage.name, 'HR Services')
        assert.equal(paymentPackage.value, 1500)
        assert.equal(paymentPackage.value, 1500)
        assert.equal(paymentPackage.VAT, 20)
        assert.equal(paymentPackage.active, true)
    })

    it('should thrown exception if name is invalid', () => {

        assert.throws(() => new PaymentPackage('', 1500), 'Name must be a non-empty string')
        assert.throws(() => new PaymentPackage(15, 1500), 'Name must be a non-empty string')
    })
    it('should thrown exception if value is invalid', () => {

        assert.throws(() => new PaymentPackage('HR Services', '1500'), 'Value must be a non-negative number')
        assert.throws(() => new PaymentPackage('HR Services', -1500), 'Value must be a non-negative number')
    })
    it('should thrown exception if VAT is invalid', () => {

        assert.throws(() => new PaymentPackage('HR Services', 1500).VAT = '20', 'VAT must be a non-negative number')
        assert.throws(() => new PaymentPackage('HR Services', 1500).VAT = -20, 'VAT must be a non-negative number')
    })
    it('should thrown exception if active is invalid', () => {

        assert.throws(() => new PaymentPackage('HR Services', 1500).active = '20', 'Active status must be a boolean')
    })
    it('test toString()', () => {
        let package = new PaymentPackage('HR Services',1500)
        const output = [
            `Package: ${package.name}` + (package.active === false ? ' (inactive)' : ''),
            `- Value (excl. VAT): ${package.value}`,
            `- Value (VAT ${package.VAT}%): ${package.value * (1 + package.VAT / 100)}`
        ].join('\n');
        assert.equal(package.toString(),output)
    })
    it('test toString() when active is false', () => {
        let package = new PaymentPackage('HR Services',1500)
        package.active = false;
        const output = [
            `Package: ${package.name}` + (package.active === false ? ' (inactive)' : ''),
            `- Value (excl. VAT): ${package.value}`,
            `- Value (VAT ${package.VAT}%): ${package.value * (1 + package.VAT / 100)}`
        ].join('\n');
        assert.equal(package.toString(),output)
    })
    it('test toString() when value is zero', () => {
        let package = new PaymentPackage('HR Services',0)
        package.active = false;
        const output = [
            `Package: ${package.name}` + (package.active === false ? ' (inactive)' : ''),
            `- Value (excl. VAT): ${package.value}`,
            `- Value (VAT ${package.VAT}%): ${package.value * (1 + package.VAT / 100)}`
        ].join('\n');
        assert.equal(package.toString(),output)
    })
   
});
