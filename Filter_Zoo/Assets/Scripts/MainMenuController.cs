using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Script "MainMenuController" Manages actions from main menu
/// </summary>
public class MainMenuController : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Debug.Log("Ich bin aus!");
        Application.Quit();
    }
}
