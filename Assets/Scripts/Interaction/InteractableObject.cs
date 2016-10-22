using UnityEngine;
using System.Collections;

public class InteractableObject : MonoBehaviour
{

    #region Public Vars

    public float m_VelocityFactor = 20000.0f;
    public float m_RotationFactor = 400.0f;

    #endregion

    #region Private Vars

    private bool m_IsGrabbed;

    private Rigidbody m_Rigidbody;

    private Grabber m_CurrentHandGrabbing;

    private Transform m_PointOfInteraction;

    #endregion

    // -----------------------------------------------------------------------------

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

        m_PointOfInteraction = new GameObject().transform;

        m_VelocityFactor /= m_Rigidbody.mass;
        m_RotationFactor /= m_Rigidbody.mass;
    }

    // -----------------------------------------------------------------------------

    void Update()
    {
        if (m_CurrentHandGrabbing && m_IsGrabbed)
        {
            Vector3 VectorBetweenHandAndInteraction = m_CurrentHandGrabbing.transform.position - m_PointOfInteraction.position;
            this.m_Rigidbody.velocity = VectorBetweenHandAndInteraction * m_VelocityFactor * Time.fixedDeltaTime;

            Quaternion RotationOfHand = m_CurrentHandGrabbing.transform.rotation * Quaternion.Inverse(m_PointOfInteraction.rotation);

            float AngleInDegree;
            Vector3 RotationAxis;

            RotationOfHand.ToAngleAxis(out AngleInDegree, out RotationAxis);

            if (AngleInDegree > 180)
            {
                AngleInDegree -= 360;
            }

			this.m_Rigidbody.angularVelocity = (Time.deltaTime * AngleInDegree * RotationAxis) * m_RotationFactor;
        }
    }

    // -----------------------------------------------------------------------------

    public void BeginInteraction(Grabber _Hand)
    {
        m_CurrentHandGrabbing = _Hand;

        m_PointOfInteraction.position = _Hand.transform.position;
        m_PointOfInteraction.rotation = _Hand.transform.rotation;
        m_PointOfInteraction.SetParent(transform, true);

        m_IsGrabbed = true;
    }

    // -----------------------------------------------------------------------------

    public void EndInteraction(Grabber _Hand)
    {
        if (m_CurrentHandGrabbing == _Hand)
        {
            m_CurrentHandGrabbing = null;
            m_IsGrabbed           = false;
        }
    }

    // -----------------------------------------------------------------------------

    public bool IsInteracting()
    {
        return m_IsGrabbed;
    }
}