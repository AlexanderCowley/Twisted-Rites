using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_MouseLook : MonoBehaviour {

    public float mouseSpeedV = 45f;
    public float v;
    public float MinimumV =-90.0f;
    public float MaximumV =90.0f;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        v += -mouseSpeedV * Time.deltaTime * Input.GetAxis("Mouse Y");
        v = Mathf.Clamp(v, MinimumV, MaximumV);
        transform.localEulerAngles = new Vector3(v,0,0);

    }
}
