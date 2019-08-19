using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_WeaponSwitch : MonoBehaviour {

    public enum weaponary { none, Shotgun, SuperShotgun, Spear, Book, Axe, Sword, Grenade }
    public Transform[] weaponTrans = new Transform[2];
    public int currentWeapon;
    public int lastWeapon;

	// Use this for initialization
	void Start () {

	}

    public void EquipWeapon(int num)
    {
        currentWeapon = num;
        for(int i = 0; i <weaponTrans.Length; i++)
        {
            if (i == num)
            {
                weaponTrans[i].gameObject.SetActive(true);
            }
            else
            {
                weaponTrans[i].gameObject.SetActive(false);
            }
        }

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            EquipWeapon(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EquipWeapon(1);
        }

    }
    }
