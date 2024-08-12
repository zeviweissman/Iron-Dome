function startTimer(time) {
   
    let timerElement = document.getElementById('timer');
    let interval = setInterval(function () {
        if (time <= 0) {
            clearInterval(interval);
            timerElement.innerHTML = "Time's up!";
        } else {
            timerElement.innerHTML = time.toFixed(1);
            time -= 0.1;
        }
    }, 100);
}