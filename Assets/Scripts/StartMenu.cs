using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

	public void PlayButton() => SceneManager.LoadScene((int)Scenes.LIVING_ROOM);
	
	public void ContinueButton() {
		print("Continue");
	}

	public void SettingsButton() => SceneManager.LoadScene((int)Scenes.SETTINGS);

	public void QuitButton() =>
		//print("Quit");
		Application.Quit();
}
