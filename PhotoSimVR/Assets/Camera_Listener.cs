using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Camera_Listener : MonoBehaviour {

    public static bool pressed;

	// Use this for initialization
	void Start () {
        if(GetComponent<VRTK_ControllerEvents>() == null)
            {
            VRTK_Logger.Error(VRTK_Logger.GetCommonMessage(VRTK_Logger.CommonMessageKeys.REQUIRED_COMPONENT_MISSING_FROM_GAMEOBJECT, "VRTK_ControllerEvents_ListenerExample", "VRTK_ControllerEvents", "the same"));
            return;
        }

        GetComponent<VRTK_ControllerEvents>().GripPressed += Camera_Listener_GripPressed;

    }

    private void Camera_Listener_GripPressed(object sender, ControllerInteractionEventArgs e)
    {
        if (TakePicture.triggered == true)
        {
            pressed = true;
           //Debug.Log("pressed");
        }
    }
}
