using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float time = 100f;
    public TMP_Text timerText;

    bool gamestop = false;

    void Start()
    {
    }

    void Update() //counts down the time and ends the game when time runs out
    {
        if (gamestop) return;

        if (time > 0)
        {
            time -= Time.deltaTime;
            timerText.text = Mathf.Ceil(time).ToString();
        }
        else
        {
            stop();
        }
    }

    void stop()
    {
        gamestop = true;
        time = 0;
        timerText.text = "0";
        SceneManager.LoadScene("Gameover");
    }
}
