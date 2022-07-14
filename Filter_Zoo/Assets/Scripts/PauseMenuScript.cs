using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{

  public GameObject Menu;
  public GameObject Player;
  // Start is called before the first frame update
  void Start()
  {
    Menu.SetActive(false);
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Escape))
    {
      if (Menu.activeSelf == false)
      {
        SetMenu();
      }
      else
      {
        CloseMenu();
      }
    }

  }

  public void SetMenu()
  {
    Cursor.lockState = CursorLockMode.None;
    Cursor.visible = true;
    Menu.SetActive(true);
    Time.timeScale = 0.0f;
  }

  public void CloseMenu()
  {
    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;
    Menu.SetActive(false);
    Time.timeScale = 1.0f;
  }

  public void RestartGame()
  {
    Singleton.Instance.ResetSingleton();
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  public void Quit()
  {
    Debug.Log("Ich bin aus!");
#if UNITY_EDITOR
    // Application.Quit() does not work in the editor so
    // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
    UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
  }

}
