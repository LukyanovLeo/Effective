function startTimer(id, hours, minutes, seconds) {
    if (seconds == 0) {
      if (minutes == 0) {
        if (hours == 0) {
          alert("Время вышло");
          window.location.reload();
          return;
        }
        hours--;
        minutes = 60;
        if (hours < 10) hours = "0" + hours;
      }
      minutes--;
      if (minutes < 10) minutes = "0" + minutes;
      seconds = 59;
    }
    else seconds--;
    if (seconds < 10) seconds = "0" + seconds;
    document.getElementById(id).innerHTML = hours+":"+minutes+":"+seconds;
    setTimeout(function() { startTimer(id, hours, minutes, seconds); }, 1000);
  }

  function startStopwatch(id) {
    var secs = parseInt(document.getElementById(id).innerHTML);
    secs++;    
    document.getElementById(id).innerHTML = secs;
    setTimeout(function() { startStopwatch(id); }, 1000);
  }

  function showCoordinates() {
    var monitor = document.getElementById('monitor').innerHTML; 
    monitor = event.clientX+':'+event.clientY
  }