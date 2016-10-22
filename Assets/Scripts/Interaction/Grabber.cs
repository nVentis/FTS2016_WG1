using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Grabber : MonoBehaviour
{
    #region Private Vars

    private HashSet<InteractableObject> m_Objects = new HashSet<InteractableObject>();

    private InteractableObject m_ClosestItemToHand;
    private InteractableObject m_InteractingItem;

    SteamVRControllerEvents m_ControllerEvents;

    #endregion

    // -----------------------------------------------------------------------------

    void Start ()
    {
        m_ControllerEvents = GetComponent<SteamVRControllerEvents>();
    }
	
    // -----------------------------------------------------------------------------

	void Update ()
    {
        // -----------------------------------------------------------------------------
        // Interaction
        // -----------------------------------------------------------------------------
        if (m_ControllerEvents.GetPressDownGrip())
        {
            GrabObject();
        }

        if (m_ControllerEvents.GetPressUpGrip())
        {
            UngrabObject();
        }
    }

    // -----------------------------------------------------------------------------

    private void OnTriggerEnter(Collider _Collider)
    {
        InteractableObject CollidedObject = _Collider.GetComponent<InteractableObject>();

        if (CollidedObject)
        {
            m_Objects.Add(CollidedObject);
        }
    }

    // -----------------------------------------------------------------------------

    private void OnTriggerExit(Collider _Collider)
    {
        InteractableObject CollidedObject = _Collider.GetComponent<InteractableObject>();

        if (CollidedObject)
        {
            m_Objects.Remove(CollidedObject);
        }
    }

    // -----------------------------------------------------------------------------

    private void GrabObject()
    {
        // -----------------------------------------------------------------------------
        // If object is already grab release the old one
        // -----------------------------------------------------------------------------
        if (ObjectIsGrabbed())
        {
            UngrabObject();
        }

        // -----------------------------------------------------------------------------
        // Look for closest object in range and grab it
        // -----------------------------------------------------------------------------
        float MinimalDistanceToObject = float.MaxValue;

        foreach (InteractableObject CurrentObject in m_Objects)
        {
            float DistanceToObject = (CurrentObject.transform.position - transform.position).sqrMagnitude;

            if (DistanceToObject < MinimalDistanceToObject)
            {
                MinimalDistanceToObject = DistanceToObject;
                m_ClosestItemToHand = CurrentObject;
            }
        }

        m_InteractingItem = m_ClosestItemToHand;

        if (m_InteractingItem)
        {
            m_InteractingItem.BeginInteraction(this);
        }
    }

    // -----------------------------------------------------------------------------

    private void UngrabObject()
    {
        if (ObjectIsGrabbed() == false)
        {
            return;
        }

        m_InteractingItem.EndInteraction(this);
    }

    // -----------------------------------------------------------------------------

    private bool ObjectIsGrabbed()
    {
        return m_InteractingItem != null;
    }
}
