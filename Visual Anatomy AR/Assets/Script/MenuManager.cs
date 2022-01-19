using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
  public void PlayGame()
  {
        SceneManager.LoadScene("MainGameplay");
  }

    public void playQuiz()
    {
        SceneManager.LoadScene("Quiz");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
