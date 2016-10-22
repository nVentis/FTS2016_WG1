#pragma strict

var currentTime = 0.0;
var alreadyPlaying = false;

function Start () {

}

function FixedUpdate () {
	currentTime = currentTime + Time.deltaTime;

	if (currentTime > 2.0 && !alreadyPlaying) {
		alreadyPlaying = true;
		var respawnSound = GetComponent.<AudioSource>();
		respawnSound.Play();
	}

	if (currentTime > 5.0) {
		Application.LoadLevel("StartScene");
	}
}