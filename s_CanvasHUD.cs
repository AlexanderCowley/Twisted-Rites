using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class s_CanvasHUD : MonoBehaviour {

    public Text t_gameOver;
    public Text t_pause;
    public Image i_crosshair;
    public Button b_retry;
    public Button b_quit;
    public Button b_resume;
    public bool gamepaused;

    // Use this for initialization
    void Start() {
        Time.timeScale = 1;
    }

    public void pauseMenu(bool continueGame)
    {
        t_pause.gameObject.SetActive(continueGame);
        b_resume.gameObject.SetActive(continueGame);
        b_quit.gameObject.SetActive(continueGame);

        if (continueGame == false)
        {
        Time.timeScale = 1;
        }

        if (continueGame == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
        }

    }

    public void gameOverState(bool playerDied)
    {
        t_gameOver.gameObject.SetActive(playerDied);
        b_retry.gameObject.SetActive(playerDied);
        b_quit.gameObject.SetActive(playerDied);
        i_crosshair.gameObject.SetActive(!playerDied);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
    }

    public void retryButtonClicked()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void quitButtonClicked()
    {
        Application.Quit();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gamepaused = !gamepaused;
            pauseMenu(gamepaused);
            Cursor.visible = gamepaused;
        }
	}
}
