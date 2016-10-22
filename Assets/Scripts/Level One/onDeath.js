#pragma strict

function Start () {
	//var Player = GameObject.Find("RigidBodyFPSController");
	//Player.Health = 100;
}

function Update () {
	var Player = GameObject.Find("RigidBodyFPSController");
	var yPlayer = Player.transform.position.y;

	var yLava = transform.position.y;

	if (yPlayer <= yLava + 1) {
		Debug.Log("You are dead. Respawn imminent...");
		Application.LoadLevel("StartScene");
	}
}