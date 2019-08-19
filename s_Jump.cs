using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_Jump : MonoBehaviour
{
    public float currentYpos;
    public float prevYpos;
    public float jumpHeight = 7.0f;
    public float fallingdis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 jumpH = new Vector3(0.0f, 8.0f, 0.0f);
        currentYpos = transform.position.y;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 1.5f))
            {
                jumpHeight = hit.distance;
                if (hit.collider.tag == "Ground")
                {
                    GetComponent<Rigidbody>().AddForce(jumpH, ForceMode.Impulse);
                }

            }
        }
    }

    private void LateUpdate()
    {
        fallingdis = currentYpos - prevYpos;
        prevYpos = currentYpos;
        //Speeds up fall speed
        if (fallingdis < 0)
        {
            Vector3 fallingGrav = new Vector3(0.0f, -15.0f, 0.0f);
            Physics.gravity = fallingGrav;
        }
    }
}
