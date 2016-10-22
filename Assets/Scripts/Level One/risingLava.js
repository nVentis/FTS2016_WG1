#pragma strict

var maxHeight = 10;
var Speed = 0.2; // in m per s

function Start () {

}

function Update () {
	if (transform.position.y < maxHeight) {
		transform.Translate(Vector3.up * Time.deltaTime * Speed, Space.World);
	}
}