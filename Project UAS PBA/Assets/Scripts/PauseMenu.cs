using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused;
    public GameObject pauseUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused == true)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
        else if (Input.GetKeyDown(KeyCode.M))
		{
            TransitionToMainMenu();
        }
    }
    private void ResumeGame()
	{
        pauseUI.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f;
	}

    private void PauseGame()
	{
        pauseUI.SetActive(true);
        isPaused = true;
        Time.timeScale = 0f;
    }
    public void TransitionToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
