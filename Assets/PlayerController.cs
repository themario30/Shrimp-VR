using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{

    public Camera PlayerCamera;
    public TextMeshProUGUI Text;

    GameObject Sphere;

    float time = 0f;
    float timeout = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        Sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Sphere.GetComponent<Renderer>().material.color = Color.yellow;
        Sphere.transform.localScale *= 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 CameraRay = PlayerCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 1f));
        Sphere.transform.position = CameraRay;

        ViewRay();
        if (Time.time - time > timeout)
        {
            Text.text = "";
        }
    }

    private void ViewRay()
    {
        RaycastHit[] raycast = Physics.RaycastAll(PlayerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 5f)),100f);
        if(raycast != null)
            foreach(var hit in raycast)
            {
                if (hit.collider.tag == "Shrimp")
                {
                    hit.collider.GetComponent<ShrimpController>().Highlighted();
                    triggerInfo(hit.collider.GetComponent<ShrimpController>().getInfo());
                    break;
                }

                    //hit.collider.GetComponent<PlayableController>().isHovered();
            }
    }

    private void triggerInfo(string v)
    {
        Text.text = v;
        time = Time.time;
    }

    private void PlayerInput()
    {

        Vector3 CameraRay = PlayerCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 1f));
        Vector3 direction = CameraRay - PlayerCamera.transform.position;
        direction = direction.normalized * 0.1f;


        if (Input.GetKey(KeyCode.JoystickButton0))
        {
            //Vector3 CameraRay = PlayerCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 1f));//PlayerCamera.transform.localPosition.normalized * 0.1f;
            Vector3 pPos = transform.position;

            transform.position = new Vector3(pPos.x + direction.x, pPos.y + 0, pPos.z + direction.z);
        }
        if(Input.GetKey(KeyCode.JoystickButton1))
        {

        }
    }
}
