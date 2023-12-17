using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
  public void PlayGame()
  {
    SceneManager.LoadScene("Game");

    Debug.Log("By Maulana Ihsan");
  }
  public void Credit()
  {
    SceneManager.LoadScene("Credit");
    Debug.Log("By Maulana Ihsan");
  }
}
