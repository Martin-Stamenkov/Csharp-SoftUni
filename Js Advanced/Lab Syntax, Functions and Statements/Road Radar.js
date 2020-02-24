function solve([km, area]) {
    let result;

    const speeding = 'speeding';
    const excessiveSpeeding = 'excessive speeding';
    const recklessSpeeding = 'reckless driving';

    function limitSpeed(speed, limit) {
        if (speed - limit <= 20) {
            result = speeding;
        }
        else if (speed - limit <= 40) {
            result = excessiveSpeeding;
        }
        else {
            result = recklessSpeeding
        }
    }

    if (area == 'city' && km > 50) {

        limitSpeed(km, 50)
    }
    else if (area == 'motorway' && km > 130) {

        limitSpeed(km, 130);
    }
    else if (area == 'interstate' && km > 90) {

        limitSpeed(km, 90)
    }
    else if (area == 'residential' && km > 20) {

        limitSpeed(km, 20)
    }
    if (result != undefined) {
        console.log(result)
    }
}
solve([130, 'interstate']);
