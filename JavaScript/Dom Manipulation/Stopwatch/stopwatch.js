function stopwatch() {

    let seconds = 0;
    let minutes = 0;

    let startButton = document.querySelector("#startBtn");

    let stopButton = document.querySelector("#stopBtn");

    let timer = document.querySelector("#time")

    let time = null;

    startButton.addEventListener('click', () => {
        time = setInterval(add, 1000)
        startButton.disabled = true;
        stopButton.disabled = false;
        timer.textContent = '00:00'
    });
    stopButton.addEventListener('click', () => {
        clearInterval(time)
        timer.textContent = `${minutes}:${seconds}`
        startButton.disabled = false;
        stopButton.disabled = true;
    });


    function add() {

        seconds++;
        if (seconds < 10) {
            seconds = '0' + seconds
        }
        if (seconds >= 60) {
            seconds = '0' + 0;
            minutes++;
            if (minutes < 10) {
                minutes = '0' + minutes
            }
        }
        if (minutes === 0) {
            minutes = '0' + minutes;
        }
        timer.textContent = `${minutes}:${seconds}`
    }
}