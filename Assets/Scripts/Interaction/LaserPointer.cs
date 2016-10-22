using UnityEngine;
using System.Collections;

public class LaserPointer : MonoBehaviour
{
    #region Public Vars

    public Color m_RayColor = Color.cyan;

    public float m_RayThickness = 1.0f;

	public Vector3 m_HitPoint;

    #endregion

    #region Private Vars

<<<<<<< HEAD
    GameVRController m_ControllerEvents;
=======
    SteamVRControllerEvents m_ControllerEvents;
>>>>>>> e7b90ec0f52a034c1362dadd8000d438d0e80b9d

    LineRenderer m_LineRenderer;

    #endregion

    void Start ()
    {
<<<<<<< HEAD
        m_ControllerEvents = GetComponent<GameVRController>();
=======
        m_ControllerEvents = GetComponent<SteamVRControllerEvents>();
>>>>>>> e7b90ec0f52a034c1362dadd8000d438d0e80b9d

        m_LineRenderer = GetComponent<LineRenderer>();

		m_LineRenderer.SetWidth(m_RayThickness, m_RayThickness);
		m_LineRenderer.SetColors(m_RayColor, m_RayColor);
        m_LineRenderer.enabled = false;
    }

    // -----------------------------------------------------------------------------

	void Update ()
    {
        m_LineRenderer.enabled = false;

<<<<<<< HEAD
        if (m_ControllerEvents.GetPressTouchpadButton1())
=======
        if (m_ControllerEvents.GetPressTrigger())
>>>>>>> e7b90ec0f52a034c1362dadd8000d438d0e80b9d
	    {
            StopCoroutine("ShowLaser");
            StartCoroutine("ShowLaser");
	    }
	}

    // -----------------------------------------------------------------------------

    private void ShowLaser()
    {
		RaycastHit Hit;

		Ray RayInWorld = new Ray(transform.position, transform.forward);

        m_LineRenderer.enabled = true;

        m_LineRenderer.SetPosition(0, RayInWorld.origin);

		if (Physics.Raycast(RayInWorld, out Hit, 100))
        {
            m_LineRenderer.SetPosition(1, Hit.point);

			m_HitPoint = Hit.point;
        }
        else
        {
            m_LineRenderer.SetPosition(1, RayInWorld.GetPoint(100));
        }
    }
}
