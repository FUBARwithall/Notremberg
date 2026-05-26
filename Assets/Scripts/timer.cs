using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float elapsed = 0f;
    private bool isRunning = true;

    void Update()
    {
        if (!isRunning || Time.timeScale == 0f) return;

        elapsed += Time.deltaTime;
        timerText.text = FormatTime(elapsed);
    }

    public void StopTimer()
    {
        isRunning = false;
    }

    public float GetTime()
    {
        return elapsed;
    }

    string FormatTime(float time)
    {
        int minutes = (int)time / 60;
        int seconds = (int)time % 60;
        int ms = (int)((time % 1) * 100);
        return string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, ms);
    }
}