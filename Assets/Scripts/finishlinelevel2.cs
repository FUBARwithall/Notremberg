using UnityEngine;
using UnityEngine.SceneManagement;

public class finishlinelevel2 : MonoBehaviour
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