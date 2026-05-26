using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class finishscreen : MonoBehaviour
{
    public GameObject finishPanel;
    public TextMeshProUGUI timeText;
    private timer timer;

    void Start()
    {
        finishPanel.SetActive(false);
        timer = FindObjectOfType<timer>();
    }

    public void ShowFinishScreen()
    {
        finishPanel.SetActive(true);
        Time.timeScale = 0f;
        SetCursor(true);

        float t = timer.GetTime();
        int minutes = (int)t / 60;
        int seconds = (int)t % 60;
        int ms = (int)((t % 1) * 100);
        timeText.text = string.Format("Your Time: {0:00}:{1:00}:{2:00}", minutes, seconds, ms);
    }

    public void NextLevel()
    {
        Time.timeScale = 1f;
        SetCursor(false);
        int next = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(next);
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SetCursor(true);
        SceneManager.LoadScene(0);
    }

    void SetCursor(bool show)
    {
        Cursor.lockState = show ? CursorLockMode.None : CursorLockMode.Locked;
        Cursor.visible = show;
    }
}