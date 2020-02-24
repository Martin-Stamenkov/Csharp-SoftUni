function attachEventsListeners() {

    let input = document.getElementById('inputDistance')
    let button = document.getElementById('convert')
    let inputUnits = document.getElementById('inputUnits')
    let outputUnits = document.getElementById('outputUnits')
    let outputDistance = document.getElementById('outputDistance')
    console.log(inputUnits.value)

    button.addEventListener('click', () => {

        let totalMetters;
        let distanceConverted;

        if (inputUnits.value === 'km') totalMetters = +input.value * 1000;
        else if (inputUnits.value === 'm') totalMetters = +input.value * 1
        else if (inputUnits.value === 'cm') totalMetters = +input.value * 0.01
        else if (inputUnits.value === 'mm') totalMetters = +input.value * 0.001
        else if (inputUnits.value === 'mi') totalMetters = +input.value * 1609.34
        else if (inputUnits.value === 'yrd') totalMetters = +input.value * 0.9144
        else if (inputUnits.value === 'ft') totalMetters = +input.value * 0.3048
        else if (inputUnits.value === 'in') totalMetters = +input.value * 0.0254

        if (outputUnits.value === 'km') distanceConverted = +totalMetters / 1000
        else if (outputUnits.value === 'm') distanceConverted = +totalMetters / 1
        else if (outputUnits.value === 'cm') distanceConverted = +totalMetters /0.01
        else if (outputUnits.value === 'mm') distanceConverted = +totalMetters /0.001
        else if (outputUnits.value === 'mi') distanceConverted = +totalMetters / 1609.34
        else if (outputUnits.value === 'yrd') distanceConverted = +totalMetters / 0.9144
        else if (outputUnits.value === 'ft') distanceConverted = +totalMetters /  0.3048
        else if (outputUnits.value === 'in') distanceConverted = +totalMetters /  0.0254

        outputDistance.value = distanceConverted
    })

}