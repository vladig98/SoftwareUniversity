function timeToWalk(steps, footLength, speed) {
    let totalMetersWalked = steps * footLength;
    let additionalMinutes = Math.floor(totalMetersWalked / 500.0);
    let totalHours = (totalMetersWalked / 1000.0) / speed;
    let totalSeconds = (totalHours * 60 + additionalMinutes) * 60;

    let hours = Math.floor(totalSeconds / 3600.0);

    totalSeconds -= hours * 3600;

    let minutes = Math.floor(totalSeconds / 60.0);

    totalSeconds -= minutes * 60;

    let seconds = Math.round(totalSeconds);

    let pad = function(num, size) {
        var s = "000000000" + num;
        return s.substring(s.length-size);
    }

    console.log(`${pad(hours, 2)}:${pad(minutes, 2)}:${pad(seconds, 2)}`);
}

timeToWalk(4000, 0.60, 5);