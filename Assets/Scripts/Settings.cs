using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{

    [SerializeField]
    private GameObject mainMenu;
    [SerializeField]
    private GameObject settings;
    [SerializeField]
    private GameObject resetProgress;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SettingsCloseButton()
    {
        gameObject.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void OpenIngameSettings()
    {
        settings.SetActive(true);
        Time.timeScale = 0f;
    }

    public void CloseIngameSettings()
    {
        settings.SetActive(false);
        Time.timeScale = 1f;
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }

    public void ResetProgress()
    {
        resetProgress.SetActive(true);
    }

    public void ResetProgressConfirm()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("MainMenu");
    }
}
