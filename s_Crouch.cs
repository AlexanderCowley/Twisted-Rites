using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_Crouch : MonoBehaviour
{
    float PlayerHeight = 2.0f;
    float PlayerCrouching = 0.5f;
    bool Crouching = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Crouch()
    {
        Vector3 Crouchingpos = new Vector3(0.0f, -1.5f, 0.0f);
        Vector3 Standingpos = new Vector3(1.2f, 2.0f, 1.2f);

        Standingpos.y = PlayerHeight;
        Crouchingpos.y = PlayerCrouching;
        BoxCollider ColliderTrans = GetComponent<BoxCollider>();

        if (Crouching == false)
        {
            //Player position (prevent fall)
            ColliderTrans.size = Crouchingpos; //Vector3.Lerp
            transform.Translate(Vector3.down, Space.Self);
            Crouching = true;
        }
        else
        {
            ColliderTrans.size = Standingpos;
            Crouching = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        //Crouch
        if (Input.GetKeyDown(KeyCode.C))
        {
            Crouch();
        }
    }
}
