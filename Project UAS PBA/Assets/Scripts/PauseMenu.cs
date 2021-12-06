using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused;
    public GameObject pauseUI;
    public GameObject timerDisplay;
    public int second = 300;
    public bool timerStart = false;
    // Start is called before the first frame update
    void Start()
    {
        Text timer = timerDisplay.GetComponent<Text>();
        timer.text = "0" + (second / 60).ToString() + ":" + (second % 60).ToString();
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
        else if (Input.GetKeyDown(KeyCode.M) && isPaused == true)
		{
            TransitionToMainMenu();
        }
        if (timerStart == false && second > 0)
		{
            StartCoroutine(CountDownTimer());
		}
        if (second <= 0)
		{
            SceneManager.LoadScene("Level2 Fix");
		}
    }
    IEnumerator CountDownTimer()
	{
        Text timer = timerDisplay.GetComponent<Text>();
        timerStart = true;
        yield return new WaitForSeconds(1);
        second -= 1;
        if (second >= 60)
		{
            timer.text = (second / 60).ToString("00") + ":" + (second % 60).ToString("00");
            timerStart = false;
        }
        if (second < 60)
		{
            timer.text = "00:" + second.ToString("00");
            timerStart = false;
        }
        if (second < 0)
		{
            timerStart = true;
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
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
