 using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool isPaused = false;
    public GameObject pauseUI;
    public Transform parent;
    private GameObject pauseUIClone;

    public void PauseGame(){
        if(isPaused){
            //resume game
            /*Destroy(pauseUIClone);*/
            pauseUI.SetActive(false);
            Time.timeScale = 1f;
            isPaused = false;
        } else{
            //pause game
            pauseUIClone = Instantiate(pauseUI);
            pauseUI.SetActive(true);
            Time.timeScale = 0f;
            isPaused = true;
		}
	}

    public void ResumeButton(){
        PauseGame();
	}

    public void SettingsButton(){
        SceneManager.LoadSceneAsync((int)Scenes.SETTINGS);
	}

	public void QuitButton() {
        Application.Quit();
	}
}
