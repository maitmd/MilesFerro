using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

	public void playButton() => SceneManager.LoadScene((int)Scenes.LIVING_ROOM);
	
	public void continueButton() {
		print("Continue");
	}

	public void settingsButton() => SceneManager.LoadScene((int)Scenes.SETTINGS);

	public void quitButton() =>
		print("Quit");
		//Application.Quit();
}
