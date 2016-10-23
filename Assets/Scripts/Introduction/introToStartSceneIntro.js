#pragma strict

var currentTime = 0.0;

function Start () {

}

function FixedUpdate () {
	currentTime = currentTime + Time.deltaTime;

	if (currentTime > 6.0) {
		Application.LoadLevel("StartScene Intro");
	}
}