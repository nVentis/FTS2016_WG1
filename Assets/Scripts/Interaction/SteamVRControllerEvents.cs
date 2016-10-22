using UnityEngine;
using System.Collections;

public class SteamVRControllerEvents : MonoBehaviour 
{
    #region Public Vars

    public bool m_GripPressed;
    public bool m_TriggerPressed;
    public bool m_ApplicationMenuPressed;
    public bool m_TouchpadPressed;
    public bool m_TouchpadTouched;

    public float m_TriggerIntensity;

<<<<<<< HEAD
    public Vector2 m_TouchPosition;

=======
>>>>>>> e7b90ec0f52a034c1362dadd8000d438d0e80b9d
    #endregion

    #region Private Vars

    private SteamVR_Controller.Device m_NativeController;

    #endregion

    // -----------------------------------------------------------------------------

<<<<<<< HEAD
    public void Start () 
=======
    void Start () 
>>>>>>> e7b90ec0f52a034c1362dadd8000d438d0e80b9d
	{
        SteamVR_TrackedObject SteamVRTrackedObject = GetComponent<SteamVR_TrackedObject>();

        m_NativeController = SteamVR_Controller.Input((int)SteamVRTrackedObject.index);
    }

    // -----------------------------------------------------------------------------

<<<<<<< HEAD
    public void Update () 
=======
    void Update () 
>>>>>>> e7b90ec0f52a034c1362dadd8000d438d0e80b9d
	{
        // -----------------------------------------------------------------------------
        // Status check
        // -----------------------------------------------------------------------------
        if (m_NativeController == null)
        {
            Debug.Log("Controller not initialized");

            return;
        }

<<<<<<< HEAD
        if (Debug.isDebugBuild)
        {
            m_GripPressed            = GetPressGrip();
            m_TriggerPressed         = GetPressTrigger();
            m_ApplicationMenuPressed = GetPressApplicationMenu();
            m_TouchpadPressed        = GetPressTouchpad();
            m_TouchpadTouched        = GetTouchTouchpad();

            m_TriggerIntensity = GetTriggerIntensity();

            m_TouchPosition = GetTouchPosition();
        }
=======
        m_GripPressed            = GetPressGrip();
        m_TriggerPressed         = GetPressTrigger();
        m_ApplicationMenuPressed = GetPressApplicationMenu();
        m_TouchpadPressed        = GetPressTouchpad();
        m_TouchpadTouched        = GetTouchTouchpad();

        m_TriggerIntensity = GetTriggerIntensity();
>>>>>>> e7b90ec0f52a034c1362dadd8000d438d0e80b9d
    }

    // -----------------------------------------------------------------------------

    public bool GetPressDownGrip()
    {
        return m_NativeController.GetPressDown(Valve.VR.EVRButtonId.k_EButton_Grip);
    }
    
    // -----------------------------------------------------------------------------

    public bool GetPressUpGrip()
    {
        return m_NativeController.GetPressUp(Valve.VR.EVRButtonId.k_EButton_Grip);
    }

    // -----------------------------------------------------------------------------

    public bool GetPressGrip()
    {
        return m_NativeController.GetPress(Valve.VR.EVRButtonId.k_EButton_Grip);
    }

    // -----------------------------------------------------------------------------

    public bool GetPressDownTrigger()
    {
        return m_NativeController.GetPressDown(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger);
    }

    // -----------------------------------------------------------------------------

    public bool GetPressUpTrigger()
    {
        return m_NativeController.GetPressUp(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger);
    }

    // -----------------------------------------------------------------------------

    public bool GetPressTrigger()
    {
        return m_NativeController.GetPress(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger);
    }

    // -----------------------------------------------------------------------------

    public bool GetPressDownApplicationMenu()
    {
        return m_NativeController.GetPressDown(Valve.VR.EVRButtonId.k_EButton_ApplicationMenu);
    }

    // -----------------------------------------------------------------------------

    public bool GetPressUpApplicationMenu()
    {
        return m_NativeController.GetPressUp(Valve.VR.EVRButtonId.k_EButton_ApplicationMenu);
    }

    // -----------------------------------------------------------------------------

    public bool GetPressApplicationMenu()
    {
        return m_NativeController.GetPress(Valve.VR.EVRButtonId.k_EButton_ApplicationMenu);
    }

    // -----------------------------------------------------------------------------

    public bool GetPressDownTouchpad()
    {
        return m_NativeController.GetPressDown(Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad);
    }

    // -----------------------------------------------------------------------------

    public bool GetPressUpTouchpad()
    {
        return m_NativeController.GetPressUp(Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad);
    }

    // -----------------------------------------------------------------------------

    public bool GetPressTouchpad()
    {
        return m_NativeController.GetPress(Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad);
    }

    // -----------------------------------------------------------------------------

    public bool GetTouchDownTouchpad()
    {
        return m_NativeController.GetTouchDown(Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad);
    }

    // -----------------------------------------------------------------------------

    public bool GetTouchUpTouchpad()
    {
        return m_NativeController.GetTouchUp(Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad);
    }

    // -----------------------------------------------------------------------------

    public bool GetTouchTouchpad()
    {
        return m_NativeController.GetTouch(Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad);
    }

    // -----------------------------------------------------------------------------

    public float GetTriggerIntensity()
    {
        return m_NativeController.GetAxis(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger).x;
    }
<<<<<<< HEAD

    // -----------------------------------------------------------------------------

    public Vector2 GetTouchPosition()
    {
        return m_NativeController.GetAxis(Valve.VR.EVRButtonId.k_EButton_Axis0);
    }
=======
>>>>>>> e7b90ec0f52a034c1362dadd8000d438d0e80b9d
}