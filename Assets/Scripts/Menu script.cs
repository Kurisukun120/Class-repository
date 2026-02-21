using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void NewGame()
    {
        Debug.Log("New Game");
        SceneManager.LoadScene("Gameplay");
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
     public void Retry()
    {
        Debug.Log("Retry");
        SceneManager.LoadScene("Gameplay");
    }
}

