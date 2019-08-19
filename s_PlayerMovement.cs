using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_PlayerMovement : MonoBehaviour {

    float mouseSpeedH = 3.0f;


    // Use this for initialization
    void Start () {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
	}

    // Update is called once per frame
    void Update ()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 10.0f;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * 10.0f;

        //MouseLook
        float h = mouseSpeedH * Input.GetAxis("Mouse X");
        //Rotates camera
        transform.Rotate(0, h, 0);

        //Player WASD key Movement
        transform.Translate(x,0,y);

    }

}
