using UnityEngine;
using System.Collections;

public class RisingLavaSharp : MonoBehaviour {

    public GameObject player;
    public Transform m_TargetPosition;
	public float maxHeight = 32.98f;
	public float Speed = 0.1f; // in m per s
	public float currentTime = 0.0f;
	public WinArea m_WinAreaScript;
	public GameObject winSoundObject;

	private bool m_IsActive = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (!m_IsActive)
			return;

		currentTime = currentTime + Time.deltaTime;
		if (transform.position.y < maxHeight) {
			transform.Translate(Vector3.up * Time.deltaTime * Speed, Space.World);
		} else {
			if (currentTime >= 8) {
				if(m_WinAreaScript.GetIsInside())
				{
                    player.transform.position = new Vector3(m_TargetPosition.position.x, m_TargetPosition.position.y, m_TargetPosition.position.z);

					m_IsActive = false;
					winSoundObject.GetComponent<AudioSource>().Play();
				}else{
					Application.LoadLevel("Death");
				}
			}
		}
	}
}
