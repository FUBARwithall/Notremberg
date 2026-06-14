using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    [SerializeField] private GameObject mapsPanel;
    [SerializeField] private GameObject settingsPanel;

    public void playgame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void ShowMapsPanel()
    {
        if (mapsPanel != null)
            mapsPanel.SetActive(true);
    }

    public void HideMapsPanel()
    {
        if (mapsPanel != null)
            mapsPanel.SetActive(false);
    }

    public void ShowSettingsPanel()
    {
        if (settingsPanel != null)
            settingsPanel.SetActive(true);
    }

    public void HideSettingsPanel()
    {
        if (settingsPanel != null)
            settingsPanel.SetActive(false);
    }

    public void SetUseMph(bool useMph)
    {
        PlayerPrefs.SetInt("UseMph", useMph ? 1 : 0);
        PlayerPrefs.Save();
    }

    public void SetDamageEnabled(bool enabled)
    {
        PlayerPrefs.SetInt("DamageEnabled", enabled ? 1 : 0);
        PlayerPrefs.Save();
    }

    public void LoadLevel1()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void LoadLevel2()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void quitgame()
    {
        Debug.Log("Game Quit!");

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
