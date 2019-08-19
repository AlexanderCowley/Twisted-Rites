using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class s_Shotgun : MonoBehaviour {

    public s_Ammo Shells;
    public Camera PlayerCamera;
    Vector3 rayCam;
    public sHealth s_Health;
    public s_CanvasHUD sCanvasHud;
    public Text AmmoCounter;

    // Use this for initialization
    void Start()
    {
        PlayerCamera = GetComponentInParent<Camera>();
        Shells = GetComponentInParent<s_Ammo>();
        updateAmmo();
    }

    public void FireWeapon()
    {
        //Centers line based on view of camera
        rayCam = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));
        RaycastHit hit;
        //Checks for ammo
        if(Shells.currentShells > 0)
        {
            //Checks raycast
            if (Physics.Raycast(rayCam, PlayerCamera.transform.forward, out hit))
            {
                Shells.ammoLost(1);
                updateAmmo();
                sHealth s_Health = hit.transform.GetComponent<sHealth>();

                if (s_Health != null)
                {
                    s_Health.DamageTaken(30);
                }

            }
            
        }

    }

    public void updateAmmo()
    {
        AmmoCounter.text = "Shells: " + Shells.currentShells.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && sCanvasHud.gamepaused == false)
        {
            FireWeapon();
        }

    }
}
