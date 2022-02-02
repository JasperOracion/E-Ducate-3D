using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Animator transition;

    [SerializeField]
    private GameObject settings;
    [SerializeField]
    private GameObject scores;
    [SerializeField]
    private GameObject mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenuSettingsButton()
    {
        gameObject.SetActive(false);
        settings.SetActive(true);
    }

    public void MainMenuPlayButton()
    {
        LoadLevel("Camp");
    }

    public void MainMenuScoresButton()
    {
        gameObject.SetActive(false);
        scores.SetActive(true);
    }

    public void MainMenuExitButton()
    {
        Application.Quit();
    }

    public void LoadLevel(string sceneName)
    {
        StartCoroutine(LoadSceneAsync(sceneName));
    }

    private IEnumerator LoadSceneAsync(string levelName)
    { 
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(levelName);
    }
}
