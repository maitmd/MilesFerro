 using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public Transitions transition;

	private void Start() {
        transition = gameObject.AddComponent<Transitions>();
	}

    public void ResumeButton(){
		print("Resuming Game");
        transition.ReturnScene("PauseScreen");
	}

    public void SettingsButton(){
        
        transition.doubleNonGame("SettingScene", SceneManager.GetActiveScene().name);
	}

	public void QuitButton() {
        print("quitting");
        //Application.Quit();
	}
}
