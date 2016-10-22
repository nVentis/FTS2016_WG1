using UnityEngine;
using System.Collections;

public class Beam : MonoBehaviour 
{
	#region Public Vars

	public GameObject m_ObjectToBeam;

	#endregion

	#region Private Vars

<<<<<<< HEAD
	GameVRController m_ControllerEvents;
=======
	SteamVRControllerEvents m_ControllerEvents;
>>>>>>> e7b90ec0f52a034c1362dadd8000d438d0e80b9d
	LaserPointer m_LaserPointer;

	#endregion

	// Use this for initialization
	void Start () 
	{
<<<<<<< HEAD
		m_ControllerEvents = GetComponent<GameVRController>();
=======
		m_ControllerEvents = GetComponent<SteamVRControllerEvents>();
>>>>>>> e7b90ec0f52a034c1362dadd8000d438d0e80b9d
		m_LaserPointer     = GetComponent<LaserPointer>();
	}
	
	// Update is called once per frame
	void Update () 
	{
<<<<<<< HEAD
		if (m_ControllerEvents.GetPressUpTouchpadButton1()) 
=======
		if (m_ControllerEvents.GetPressDownApplicationMenu()) 
>>>>>>> e7b90ec0f52a034c1362dadd8000d438d0e80b9d
		{
			BeamObject();
		}
	}

	private void BeamObject()
	{
		m_ObjectToBeam.transform.position = m_LaserPointer.m_HitPoint;
	}
}
