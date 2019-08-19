using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_Ammo : MonoBehaviour {

    public const int maxShells = 50;
    public int currentShells = maxShells;

	// Use this for initialization
	void Start () {
		
	}

    public void ammoLost(int ammoUsed)
    {
        currentShells -= ammoUsed;
        if (currentShells < 0)
        {
            currentShells = 0;
        }
    }

    public void ammoRecover(int ammoGained)
    {
        currentShells += ammoGained;
        if (currentShells >= maxShells)
        {
            currentShells = maxShells;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
