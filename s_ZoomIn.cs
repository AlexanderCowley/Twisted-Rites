using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_ZoomIn : MonoBehaviour
{

    public Camera playerCamera;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            playerCamera.fieldOfView = 50;
        }
        if (Input.GetMouseButtonUp(1))
        {
            playerCamera.fieldOfView = 60;
        }
    }
}
