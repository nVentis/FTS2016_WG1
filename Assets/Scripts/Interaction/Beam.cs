using UnityEngine;
using System.Collections;

public class Beam : MonoBehaviour 
{
	#region Public Vars

	public GameObject m_ObjectToBeam;

	#endregion

	#region Private Vars

	GameVRController m_ControllerEvents;
	LaserPointer m_LaserPointer;

	#endregion

	// Use this for initialization
	void Start () 
	{
		m_ControllerEvents = GetComponent<GameVRController>();
		m_LaserPointer     = GetComponent<LaserPointer>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (m_ControllerEvents.GetPressUpTouchpadButton1()) 
		{
			BeamObject();
		}
	}

	private void BeamObject()
	{
		m_ObjectToBeam.transform.position = m_LaserPointer.m_HitPoint;
	}
}
