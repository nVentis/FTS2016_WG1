using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameVRController : SteamVRControllerEvents
{
    #region Public Vars

    public enum ETouchpadType
    {
        Touch,
        Rectangle,
        Cross,
    };

    public ETouchpadType m_TouchpadType;

    public bool m_Button1Pressed;
    public bool m_Button2Pressed;
    public bool m_Button3Pressed;
    public bool m_Button4Pressed;

    public float m_ButtonSensitivity = 0.2f;

    #endregion

    #region Private Vars

    private bool m_Button1;
    private bool m_Button2;
    private bool m_Button3;
    private bool m_Button4;

    #endregion

    public void Start ()
    {
        base.Start();
	}

    // -----------------------------------------------------------------------------

    public void Update ()
    {
        base.Update();

        if (Debug.isDebugBuild)
        { 
            m_Button1Pressed = GetPressTouchpadButton1();
            m_Button2Pressed = GetPressTouchpadButton2();
            m_Button3Pressed = GetPressTouchpadButton3();
            m_Button4Pressed = GetPressTouchpadButton4();
        }
    }

    // -----------------------------------------------------------------------------

    public bool GetPressDownTouchpadButton1()
    {
        if (GetPressDownTouchpad() == false) return false;

        UpdateControllerButtons();

        return m_Button1;
    }

    // -----------------------------------------------------------------------------

    public bool GetPressUpTouchpadButton1()
    {
        if (GetPressUpTouchpad() == false) return false;

        UpdateControllerButtons();

        return m_Button1;
    }

    // -----------------------------------------------------------------------------

    public bool GetPressTouchpadButton1()
    {
        if (GetPressTouchpad() == false) return false;

        UpdateControllerButtons();

        return m_Button1;
    }

    // -----------------------------------------------------------------------------

    public bool GetPressDownTouchpadButton2()
    {
        if (GetPressDownTouchpad() == false) return false;

        UpdateControllerButtons();

        return m_Button2;
    }

    // -----------------------------------------------------------------------------

    public bool GetPressUpTouchpadButton2()
    {
        if (GetPressUpTouchpad() == false) return false;

        UpdateControllerButtons();

        return m_Button2;
    }

    // -----------------------------------------------------------------------------

    public bool GetPressTouchpadButton2()
    {
        if (GetPressTouchpad() == false) return false;

        UpdateControllerButtons();

        return m_Button2;
    }

    // -----------------------------------------------------------------------------

    public bool GetPressDownTouchpadButton3()
    {
        if (GetPressDownTouchpad() == false) return false;

        UpdateControllerButtons();

        return m_Button3;
    }

    // -----------------------------------------------------------------------------

    public bool GetPressUpTouchpadButton3()
    {
        if (GetPressUpTouchpad() == false) return false;

        UpdateControllerButtons();

        return m_Button3;
    }

    // -----------------------------------------------------------------------------

    public bool GetPressTouchpadButton3()
    {
        if (GetPressTouchpad() == false) return false;

        UpdateControllerButtons();

        return m_Button3;
    }

    // -----------------------------------------------------------------------------

    public bool GetPressDownTouchpadButton4()
    {
        if (GetPressDownTouchpad() == false) return false;

        UpdateControllerButtons();

        return m_Button4;
    }

    // -----------------------------------------------------------------------------

    public bool GetPressUpTouchpadButton4()
    {
        if (GetPressUpTouchpad() == false) return false;

        UpdateControllerButtons();

        return m_Button4;
    }

    // -----------------------------------------------------------------------------

    public bool GetPressTouchpadButton4()
    {
        if (GetPressTouchpad() == false) return false;

        UpdateControllerButtons();

        return m_Button4;
    }

    // -----------------------------------------------------------------------------

    void UpdateControllerButtons()
    {
        switch (m_TouchpadType)
        {
            case ETouchpadType.Rectangle:
                UpdateControllerRectangle();
                break;
            case ETouchpadType.Cross:
                UpdateControllerCross();
                break;
        };
    }

    // -----------------------------------------------------------------------------

    void UpdateControllerRectangle()
    {
        m_Button1 = false;
        m_Button2 = false;
        m_Button3 = false;
        m_Button4 = false;

        Vector2 TouchPosition = GetTouchPosition();

        m_Button1 = TouchPosition.x < -m_ButtonSensitivity && TouchPosition.y < -m_ButtonSensitivity;
        m_Button2 = TouchPosition.x > +m_ButtonSensitivity && TouchPosition.y > +m_ButtonSensitivity;
        m_Button3 = TouchPosition.x < -m_ButtonSensitivity && TouchPosition.y > +m_ButtonSensitivity;
        m_Button4 = TouchPosition.x > +m_ButtonSensitivity && TouchPosition.y < -m_ButtonSensitivity;
    }

    // -----------------------------------------------------------------------------

    void UpdateControllerCross()
    {
        m_Button1 = false;
        m_Button2 = false;
        m_Button3 = false;
        m_Button4 = false;

        Vector2 TouchPosition = GetTouchPosition();

        m_Button1 = IsBetween(TouchPosition.x, 0.0f, m_ButtonSensitivity) && TouchPosition.y > +m_ButtonSensitivity;
        m_Button2 = IsBetween(TouchPosition.x, 0.0f, m_ButtonSensitivity) && TouchPosition.y < -m_ButtonSensitivity;

        m_Button3 = TouchPosition.x > +m_ButtonSensitivity && IsBetween(TouchPosition.y, 0.0f, m_ButtonSensitivity);
        m_Button4 = TouchPosition.x < -m_ButtonSensitivity && IsBetween(TouchPosition.y, 0.0f, m_ButtonSensitivity);
    }

    // -----------------------------------------------------------------------------

    bool IsButtonTouched(Vector2 _Input, Vector2 _Center, float _Radius)
    {
        float DistanceBetweenInputAndCenter = Mathf.Abs(Vector2.Distance(_Input, _Center));

        return DistanceBetweenInputAndCenter < _Radius;
    }

    // -----------------------------------------------------------------------------

    bool IsBetween(float _Input, float _Center, float _Radius)
    {
        return (_Input > (_Center - _Radius)) && (_Input < (_Center + _Radius));
    }
}
