function timer() {
   $('button#start-timer').one('click', function () {
      id = setInterval(tick, 1000)
   })

   $('button#stop-timer').one('click', function () {
      clearInterval(id);
   })
}

function tick() {
   let seconds = Number($('span#seconds').text()) + 1;
   let minutes = Number($('span#minutes').text())
   let hours = Number($('span#hours').text())

   if (seconds >= 60) {
      minutes++;
      seconds = 0;
   }

   if (minutes >= 60) {
      hours++;
      minutes = 0;
   }

   $('span#seconds').text(seconds.toString().length == 1 ? '0' + seconds : seconds)
   $('span#minutes').text(minutes.toString().length == 1 ? '0' + minutes : minutes)
   $('span#hours').text(hours.toString().length == 1 ? '0' + hours : hours)
}