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
	document.getElementById(id).value = hours + ":" + minutes + ":" + seconds;
	setTimeout(function () { startTimer(id, hours, minutes, seconds); }, 1000);
}

function startTimerMain(firstId, secondId, hours, minutes, seconds) {
	startTimer(firstId, hours, minutes, seconds);
	startTimer(secondId, hours, minutes, seconds);
}

function startStopwatch(id) {
	var secs = parseInt(document.getElementById(id).innerHTML);
	secs++;
	document.getElementById(id).innerHTML = secs;
	setTimeout(function () { startStopwatch(id); }, 1000);
}

function showCoordinates() {
	var secs = parseInt(document.getElementById(id).innerHTML);
	secs++;
	document.getElementById(id).innerHTML = secs;
	setTimeout(function () { startStopwatch(id); }, 1000);
}

