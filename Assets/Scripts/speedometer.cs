using UnityEngine;
using TMPro;

public class Speedometer : MonoBehaviour
{
    public TextMeshProUGUI speedText;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Time.timeScale == 0f) return;

        bool useMph = PlayerPrefs.GetInt("UseMph", 0) == 1;
        float speed = rb.linearVelocity.magnitude * (useMph ? 2.236936f : 3.6f);
        speedText.text = Mathf.RoundToInt(speed) + (useMph ? " mph" : " km/h");
    }
}
