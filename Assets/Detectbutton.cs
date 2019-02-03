using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectbutton : MonoBehaviour
{

    public Material Normal;
    public Material Touched;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Buttons
        //Keycode.JoystickButton0 is Middle Button
        //Keycode.Joystickbutton1 is the back button

        //Axis (D-UP, D-Down, D-Left, D-Right
        //
        //
        //
        //

        if(Input.GetAxis("Horizontal") > 0)
        {
            Debug.Log(Input.GetAxis("Horizontal"));
            GetComponent<Renderer>().material = Touched;

        }
        else
        {
            GetComponent<Renderer>().material = Normal;
        }
    }
}
