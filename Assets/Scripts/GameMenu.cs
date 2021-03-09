using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{

    public string gameScene;
    public string settingScene;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void playButton()
    {
        SceneManager.LoadScene(gameScene);
    }

    public void continueButton()
    {

    }

    public void SettingsButton()
    {
        SceneManager.LoadScene(settingScene);
    }

    public void quitButton()
    {
        Application.Quit();
    }
}
