using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class damagesystem : MonoBehaviour
{
    public float maxHp = 100f;
    public float currentHp;
    public float impactThreshold = 5f;
    public TextMeshProUGUI hpText;
    public GameObject gameOverPanel;

    void Start()
    {
        currentHp = maxHp;
        UpdateHpUI();
    }

    void OnCollisionEnter(Collision collision)
    {
        float impact = collision.relativeVelocity.magnitude;
        if (impact < impactThreshold) return;

        float damage = impact * 2f;
        currentHp = Mathf.Max(0f, currentHp - damage);
        UpdateHpUI();

        if (currentHp <= 0f)
            GameOver();
    }

    void UpdateHpUI()
    {
        hpText.text = "HP: " + Mathf.RoundToInt(currentHp) + "%";
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}