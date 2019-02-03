using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShrimpController : MonoBehaviour
{
    public GameObject Body;

    public Material Normal;
    public Material BadNormal;
    public Material Highlight;

    public string Name;
    public bool BadShrimp;

    private float raycastHitTime = -0.3f;
    private float periodOfTimeHighlighted = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(new Vector3(Random.Range(0f, 360f), Random.Range(0f, 360f), Random.Range(0f, 360f)));
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - raycastHitTime < periodOfTimeHighlighted)
        {
            Body.GetComponent<Renderer>().material = Highlight;
        }
        else if (BadShrimp)
            Body.GetComponent<Renderer>().material = BadNormal;
        else
            Body.GetComponent<Renderer>().material = Normal;

    }

    public void Highlighted()
    {
        raycastHitTime = Time.fixedTime;
    }

    public string getInfo()
    {
        if(BadShrimp)
        {
            return $"Shrimp {name}\nShrimp is bad. ";
        }
        else
            return $"Shrimp {name}\nShrimp is good.";

    }
}
