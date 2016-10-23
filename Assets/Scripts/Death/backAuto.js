#pragma strict

var currentTime = 0.0;
var alreadyPlaying = false;

function Start () {

}

function FixedUpdate () {
	currentTime = currentTime + Time.deltaTime;

	if (currentTime > 0.5 && !alreadyPlaying) {
		alreadyPlaying = true;
		var respawnSound = GetComponent.<AudioSource>();
		respawnSound.Play();
	}

	if (currentTime > 6.0) {
		Application.LoadLevel("StartScene");
	}
}