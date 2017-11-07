using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRTK;

public class TakePicture : MonoBehaviour {

    GameObject duck;
    GameObject pig;
    GameObject cow;
    GameObject chicken;
    GameObject sheep;
    public static bool triggered;
    public Text display;

    void Start()
    {
        // Setting up the references.
        duck = GameObject.FindGameObjectWithTag("duck");
        pig = GameObject.FindGameObjectWithTag("pig");
        cow = GameObject.FindGameObjectWithTag("cow");
        chicken = GameObject.FindGameObjectWithTag("chicken");
        sheep = GameObject.FindGameObjectWithTag("sheep");

    }

    private void OnTriggerStay(Collider other)
    {

       if(Camera_Listener.pressed == true)
        { 
            if (other.gameObject == duck)
            {
                display.text = "Duck";
            }
            else if (other.gameObject == pig)
            {
                display.text = "Pig";
            }
            else if (other.gameObject == cow)
            {
                display.text = "Cow";
            }
            else if (other.gameObject == chicken)
            {
                display.text = "Chicken";
            }
            else if (other.gameObject == sheep)
            {
                display.text = "Sheep";
            }
            Camera_Listener.pressed = false;
       }
    }

    private void OnTriggerEnter(Collider other)
    {
        triggered = true;
    }

    private void OnTriggerExit(Collider other)
    {
        triggered = false;
    }
}
