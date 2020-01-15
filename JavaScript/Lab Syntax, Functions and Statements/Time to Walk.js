function solve(steps, footLength, speed) {

    let totalMeters = footLength * steps;
    let minutesBreak = Math.floor(totalMeters / 500)

    let minutesToUni = 60 / ((speed * 1000) / totalMeters)
    let totalMinutes = minutesToUni + minutesBreak;
    let totalSeconds = Math.ceil(totalMinutes * 60);

    let result = new Date(null, null, null, null, null, totalSeconds)
     console.log(result.toTimeString().split(' ')[0]);
}
solve(2564, 0.70, 5.5);