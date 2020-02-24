let AutoService = require('./02. Auto Service_Ресурси');
let assert = require('chai').assert



let autoService;
beforeEach(() => {
    autoService = new AutoService(2)
})

describe(('AutoService'), () => {

    it('test constructor', () => {

        assert.deepEqual(autoService.garageCapacity, 2)
        assert.deepEqual(autoService.backlogWork, [])
        assert.deepEqual(autoService.workInProgress, [])

    })
    it('test availableSpace', () => {

        assert.deepEqual(autoService.availableSpace, autoService.garageCapacity - autoService.workInProgress.length)

    })
    it('test signUpForReview', () => {

        assert.deepEqual(autoService.workInProgress[0], autoService.signUpForReview('Peter', 'CA1234CA',
            { 'engine': 'MFRGG23', 'transmission': 'FF4418ZZ', 'doors': 'broken', 'wheels': 'broken', 'tires': 'broken' }),
        )

    })
    it('test signUpForReview when capacity is full', () => {

        let auto = new AutoService(1);
        auto.signUpForReview('Peter', 'CA1234CA',
            { 'engine': 'MFRGG23', 'transmission': 'FF4418ZZ', 'doors': 'broken', 'wheels': 'broken', 'tires': 'broken' })
        assert.deepEqual(auto.backlogWork[0], auto.signUpForReview('Filip', 'A3583HM',
            { 'engine': 'MFRGG23', 'transmission': 'FF4418ZZ', 'doors': 'broken', 'wheels': 'broken', 'tires': 'broken' }),
        )

    })
    it('test carInfo', () => {
        autoService.signUpForReview('Peter', 'CA1234CA', { 'engine': 'MFRGG23', 'transmission': 'FF4418ZZ', 'doors': 'broken' });
        assert.deepEqual(autoService.carInfo('CA1234CA', 'Peter'), {
            plateNumber: 'CA1234CA',
            clientName: 'Peter',
            carInfo: { engine: 'MFRGG23', transmission: 'FF4418ZZ', doors: 'broken' }
        })

    })
    it('test carInfo second case', () => {
        assert.deepEqual(autoService.carInfo('CA1234CA', 'Peter'),
            `There is no car with platenumber CA1234CA and owner Peter.`)

    })
    it('test repairCar', () => {

        assert.deepEqual(autoService.repairCar(), 'No clients, we are just chilling...');
        autoService.signUpForReview('Peter', 'CA1234CA', {'engine': 'MFRGG23', 'transmission': 'FF4418ZZ', 'doors': 'broken'});
        assert.deepEqual(autoService.repairCar(), 'Your doors were repaired.');
        autoService.signUpForReview('Philip', 'A1234KH', {'engine': 'MFRGG23', 'transmission': 'FF4418ZZ'});
        assert.deepEqual(autoService.repairCar(), 'Your car was fine, nothing was repaired.');
        

    })
})