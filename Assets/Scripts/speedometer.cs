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

        float speed = rb.linearVelocity.magnitude * 3.6f;
        speedText.text = Mathf.RoundToInt(speed) + " km/h";
    }
}