using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

	Transitions transitions;

	void Start() {
		transitions = gameObject.AddComponent<Transitions>();
	}

	public void PlayButton() {
		transitions.NonGameScene("LivingRoom", SceneManager.GetActiveScene().name, true);
	}
	
	public void ContinueButton() {
		print("Continue");
	}

	public void SettingsButton() {
		//gameObject.AddComponent<Camera>();
		transitions.NonGameScene("SettingScene", SceneManager.GetActiveScene().name, false);
	}

	public void QuitButton() {
		//print("Quit");
		Application.Quit();
	}
}
