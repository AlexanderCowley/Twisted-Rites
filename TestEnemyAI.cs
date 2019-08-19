using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemyAI : MonoBehaviour {

    public GameObject prefabBullet;
    public Transform bulletSpawn;
    public sHealth s_Health;
    public Transform playerPos;

	// Use this for initialization
	void Start () {
        InvokeRepeating("FireWeapon", 1.0f, 0.5f);
    }

    public void FireWeapon()
    {
        GameObject Bullet = Instantiate(prefabBullet, bulletSpawn.position, bulletSpawn.rotation);
        Bullet.GetComponent<Rigidbody>().velocity = Bullet.transform.forward * 5;
        Destroy(Bullet, 2.0f);
    }

    // Update is called once per frame
    void Update () {
        //transform.LookAt(playerPos);
	}
}
