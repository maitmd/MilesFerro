using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public GameController gameController;
    public string gameScene;
    public string settingScene;

    // Start is called before the first frame update
    void Start() {
        //gameController = gameObject.
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void playButton()
    {
        //GameController.instance.loadGame();
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
