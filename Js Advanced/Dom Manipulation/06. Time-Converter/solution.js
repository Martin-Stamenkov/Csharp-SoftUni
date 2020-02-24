function attachEventsListeners() {

    let daysButton = document.querySelector("#daysBtn")
    let hoursButton = document.querySelector("#hoursBtn")
    let minutesButton = document.querySelector("#minutesBtn")
    let secondsButton = document.querySelector("#secondsBtn")

    let daysBox = document.querySelector("#days")
    let hoursBox = document.querySelector("#hours")
    let minutesBox = document.querySelector("#minutes")
    let secondsBox = document.querySelector("#seconds")

    daysButton.addEventListener('click', () => {
        let days = daysBox.value;
        hoursBox.value = days * 24;
        minutesBox.value = days * 1440;
        secondsBox.value = days * 86400;

    })

    hoursButton.addEventListener('click', () => {
        let hours = hoursBox.value;
        daysBox.value = hours / 24;
        minutesBox.value = hours * 60;
        secondsBox.value = hours * 60 * 60;

    })

    minutesButton.addEventListener('click', () => {
        let minutes = minutesBox.value;
        daysBox.value = minutes / 60 / 24;
        hoursBox.value = minutes / 60;
        secondsBox.value = minutes * 60
    })

    secondsButton.addEventListener('click', () => {
        let seconds = secondsBox.value;
        daysBox.value = seconds / 60 / 60 / 24;
        hoursBox.value = seconds / 60 / 60;
        minutesBox.value = seconds / 60;
    })

}