using UnityEngine;
using UnityEngine.SceneManagement;

public class finishline : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<timer>().StopTimer();
            FindObjectOfType<finishscreen>().ShowFinishScreen();
        }
    }
}