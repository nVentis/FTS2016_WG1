#pragma strict

var maxHeight = 32;
var Speed = 0.2; // in m per s
var Counter = 0;

function Start () {

}

function FixedUpdate () {
	if (transform.position.y < maxHeight) {
		transform.Translate(Vector3.up * Time.deltaTime * Speed, Space.World);
	} else {
		Counter++;
		if (Counter == 60) {
			Application.LoadLevel("Win");
		}
	}
}