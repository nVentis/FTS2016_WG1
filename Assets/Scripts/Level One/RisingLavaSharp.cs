using UnityEngine;
using System.Collections;

public class RisingLavaSharp : MonoBehaviour {

	public float maxHeight = 32.98f;
	public float Speed = 0.2f; // in m per s
	public float currentTime = 0.0f;
	public WinArea m_WinAreaScript;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		currentTime = currentTime + Time.deltaTime;
		if (transform.position.y < maxHeight) {
			transform.Translate(Vector3.up * Time.deltaTime * Speed, Space.World);
		} else {
			if (currentTime >= 8) {
				if(m_WinAreaScript.GetIsInside()){
					Application.LoadLevel("Win");
				}else{
					Application.LoadLevel("Death");
				}
			}
		}
	}
}
