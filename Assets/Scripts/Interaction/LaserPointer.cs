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

    GameVRController m_ControllerEvents;

    LineRenderer m_LineRenderer;

    #endregion

    void Start ()
    {
        m_ControllerEvents = GetComponent<GameVRController>();

        m_LineRenderer = GetComponent<LineRenderer>();

		m_LineRenderer.SetWidth(m_RayThickness, m_RayThickness);
		m_LineRenderer.SetColors(m_RayColor, m_RayColor);
        m_LineRenderer.enabled = false;
    }

    // -----------------------------------------------------------------------------

	void Update ()
    {
        m_LineRenderer.enabled = false;

        if (m_ControllerEvents.GetPressTouchpadButton1())
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
