using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public sHealth s_Health;

	// Use this for initialization
	void Start () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        GameObject bulletDamage = collision.gameObject;
        sHealth health = bulletDamage.GetComponent<sHealth>();
        if(health != null)
        {
            if(health.currentHealth > 0)
            {
                health.DamageTaken(10);
                Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
