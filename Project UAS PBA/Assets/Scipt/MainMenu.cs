using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void TransitionToStageLevel(string sampleScene)
    {
        SceneManager.LoadScene(sampleScene);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
