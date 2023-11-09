function attachEventsListeners() {
    let days = document.getElementById('days');
    let hours = document.getElementById('hours')
    let minutes = document.getElementById('minutes')
    let seconds = document.getElementById('seconds')

    let daysBtn = document.getElementById('daysBtn')
    let hoursBtn = document.getElementById('hoursBtn')
    let minutesBtn = document.getElementById('minutesBtn')
    let secondsBtn = document.getElementById('secondsBtn')

    daysBtn.addEventListener("click", function () {
        hours.value = days.value * 24
        minutes.value = hours.value * 60
        seconds.value = minutes.value * 60;
    })

    hoursBtn.addEventListener("click", function () {
        days.value = hours.value / 24
        minutes.value = hours.value * 60
        seconds.value = minutes.value * 60
    })

    minutesBtn.addEventListener("click", function () {
        hours.value = minutes.value / 60;
        days.value = hours.value / 24
        seconds.value = minutes.value * 60
    })

    secondsBtn.addEventListener("click", function () {
        minutes.value = seconds.value / 60
        hours.value = minutes.value / 60
        days.value = hours.value / 24
    })
}