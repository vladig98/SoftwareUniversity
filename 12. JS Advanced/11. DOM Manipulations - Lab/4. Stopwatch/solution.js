window.onload = function stopWatch() {
    let startBtn = document.getElementById('startBtn');
    let stopBtn = document.getElementById('stopBtn');
    let time = document.getElementById('time');

    startBtn.addEventListener("click", function start() {
        let seconds = 0;
        let minutes = 0;
        time.innerHTML = '00:00';

        id = setInterval(() => {
            seconds += 1;

            if (seconds >= 60) {
                minutes++;
                seconds = 0;
            }

            time.innerHTML = minutes.toString().length == 1 ? (seconds.toString().length == 1 ? `0${minutes}:0${seconds}` : `0${minutes}:${seconds}`)
                : `${minutes}:${seconds}`;

        }, 1000)

        this.setAttribute("disabled", true);
        stopBtn.removeAttribute('disabled')
    })

    stopBtn.addEventListener("click", stop)


    function stop() {
        clearInterval(id);

        this.setAttribute("disabled", true);
        startBtn.removeAttribute('disabled')
    }
}