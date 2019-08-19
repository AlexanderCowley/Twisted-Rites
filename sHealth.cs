using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sHealth : MonoBehaviour {

    public s_CanvasHUD sCanvasHUD;
    public const int maxHealth = 200;
    public int currentHealth = maxHealth;
    public RectTransform pHealthbarBG;
    public RectTransform pHealthbarFG;
    public Camera DeathCam;

    // Use this for initialization
    void Start () {
        
	}

    public void DamageTaken(int damage)
    {
        // Object takes damage
        currentHealth -= damage;
        //Ensures health does not go below zero
        if(currentHealth < 0)
        {
            currentHealth = 0;
        }
        //If player takes damage
        if(this.gameObject.tag == "Player")
        {
            pHealthbarFG.sizeDelta =
                new Vector2(((float)currentHealth / (float)maxHealth) * pHealthbarBG.rect.width, pHealthbarBG.sizeDelta.y);
        }
        else
        {
            //Update Enemy Health
        }

        Die();

    }

    public void HealthRecover(int recover)
    {
        //Recovers player health
        currentHealth += recover;
        //Makes sure health does not go above 200
        if(currentHealth > 200)
        {
            currentHealth = 200;
        }

        //If player recovers health
        if (this.gameObject.tag == "Player")
        {
            pHealthbarFG.sizeDelta = 
                new Vector2(((float)currentHealth / (float)maxHealth) * pHealthbarBG.rect.width, pHealthbarBG.sizeDelta.y);
        }

    }

    public void Die()
    {
        //Something dies
        if (currentHealth <= 0)
        {
            if(this.gameObject.name == "PlayerCharacter")
            {
                sCanvasHUD.gameOverState(true);
                Instantiate(DeathCam, Camera.main.transform.position, Camera.main.transform.rotation);
                // deactivate hud, activate new menu
            }
            Destroy(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
