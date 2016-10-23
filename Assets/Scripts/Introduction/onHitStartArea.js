#pragma strict

function Start () {

}

var yTrigger = 33.0;

function Update () {
	if (transform.position.y < yTrigger) {
		Debug.Log("You are dead. Respawn imminent...");
		Application.LoadLevel("StartScene");
	}
}