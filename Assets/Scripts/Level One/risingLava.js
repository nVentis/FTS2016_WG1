#pragma strict

function Start () {

}

var maxHeight = 10;
var Speed = 1; // in m per s

function Update () {
	if (transform.position.y < maxHeight) {
		transform.Translate(Vector3.up * Time.deltaTime, Space.World);
	}
}