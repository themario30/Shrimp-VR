using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayableController : MonoBehaviour
{

    public Material Normal;
    public Material Touched;


    // Start is called before the first frame update
    void Start()
    {

    }

    public void isHovered()
    {
        GetComponent<Renderer>().material = Touched;
    }
    // Update is called once per frame
    void Update()
    {

        GetComponent<Renderer>().material = Normal;

    }
}
