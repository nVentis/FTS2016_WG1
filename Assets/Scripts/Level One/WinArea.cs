using UnityEngine;
using System.Collections;

public class WinArea : MonoBehaviour {

	public bool inWinArea = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void OnTriggerEnter(Collider _Collider)
	{
		inWinArea = true;
	}

	private void OnTriggerExit(Collider _Collider)
	{
		inWinArea = false;
	}

	public bool GetIsInside()
	{
		return inWinArea;
	}
}
