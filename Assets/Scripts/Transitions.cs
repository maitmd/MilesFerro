using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transitions : MonoBehaviour {
	public string newScene;
	public string currentScene;

	private void OnTriggerEnter2D(Collider2D collision) {
		if(gameObject.CompareTag("Enemy")) {
			Time.timeScale = 0f; //stops previous scene while BattleScene is active
			StartCoroutine(AsyncLoad(false, newScene));
			TransitionStack.PushScene(newScene);

			SceneManager.SetActiveScene(SceneManager.GetSceneByName(newScene));
			//if this doesn't work properly tell me so I can switch method to Async coroutines
		}
	}

	private void EnemyObject(string newScene){
		Time.timeScale = 0f; //stops previous scene while BattleScene is active
		StartCoroutine(AsyncLoad(false, newScene));
		TransitionStack.PushScene(newScene);

		SceneManager.SetActiveScene(SceneManager.GetSceneByName(newScene));
		//if this doesn't work properly tell me so I can switch method to Async coroutines
	}

	private void DoorObject(string newScene){
		StartCoroutine(AsyncLoad(true, newScene));
		TransitionStack.PushScene(newScene);
	}

	private void OnTriggerStay2D(Collider2D collision) {
		if(gameObject.CompareTag("Door")) {  //please have any interactable load zone tagged Door for this to work
			if(Input.GetKeyDown(KeyCode.E)) {
				//prevScene = currentScene;
				//SceneManager.LoadScene(newScene, LoadSceneMode.Single);
				StartCoroutine(AsyncLoad(true, newScene));
				TransitionStack.PushScene(newScene);
				//SceneManager.LoadScene(newScene);

			}
		}
		if(gameObject.CompareTag("Enemy")) {
			//This is for boss/stationary enemies you interact with to battle
			if(Input.GetKeyDown(KeyCode.E)) {
				//prevScene = currentScene;
				StartCoroutine(AsyncLoad(false, newScene));
				//SceneManager.LoadScene(newScene, LoadSceneMode.Additive);
				//SceneManager.LoadScene(newScene);
				TransitionStack.PushScene(currentScene);
				SceneManager.SetActiveScene(SceneManager.GetSceneByName(newScene)); 
				//if this doesn't work properly tell me so I can switch method to Async coroutines
			}
		}
	}

	public void BattleEnd(){  //call proper scene from here
		if (newScene.Equals("Win")){
			SceneManager.SetActiveScene(SceneManager.GetSceneByName(TransitionStack.PeekScene()));

			Time.timeScale = 1f;//unpauses previous scene
			SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Battle"));//after destroying BattleScene
			TransitionStack.PopScene();
			//We need to remove the object from Scene
		}
		if (newScene.Equals("Lose")){//change this when we have have a lose scene
			SceneManager.SetActiveScene(SceneManager.GetSceneByName(TransitionStack.PeekScene()));
			Time.timeScale = 1f;//unpauses previous scene

			SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Battle"));//after destroying BattleScene
			TransitionStack.PopScene();
		}
		if (newScene.Equals("Escape")){
			SceneManager.SetActiveScene(SceneManager.GetSceneByName(TransitionStack.PeekScene()));
			Time.timeScale = 1f;//unpauses previous scene
			SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Battle"));//after destroying BattleScene
			TransitionStack.PopScene();
		}
		//Add other Scenes as necessary
	}

	public void NonGameScene(string newScene, string currentScene, bool single){
		Time.timeScale = 0f;
		if(!single) { //Loading Additively
			print(SceneManager.GetActiveScene().name + " Before Coroutine");
			StartCoroutine(AsyncLoad(single, newScene));
			StartCoroutine(WaitForSceneLoad(SceneManager.GetSceneByName(newScene)));
			TransitionStack.PushScene(currentScene);
		} else { //Loading Single
			StartCoroutine(AsyncLoad(single, newScene));
			TransitionStack.PushScene(currentScene);
		}
	}
	//only use for additive scenes
	public void ReturnScene(string currentScene){
		if(currentScene == "SettingScene" && TransitionStack.PeekScene() == "LivingRoom") {
			TransitionStack.PushScene("PauseScreen");
			StartCoroutine(AsyncLoad(false, TransitionStack.PeekScene()));
			StartCoroutine(WaitForSceneLoad(SceneManager.GetSceneByName(TransitionStack.PeekScene())));
		} else {
			SceneManager.SetActiveScene(SceneManager.GetSceneByName(TransitionStack.PeekScene()));
		}
		SceneManager.UnloadSceneAsync(currentScene);
		if(SceneManager.GetActiveScene().name != "PauseScreen") {
			Time.timeScale = 1f;
		}
		TransitionStack.PopScene();
	}

	public void doubleNonGame(string newScene, string currentScene){
		Time.timeScale = 0f;
		StartCoroutine(AsyncLoad(false, newScene));
		StartCoroutine(WaitForSceneLoad(SceneManager.GetSceneByName(newScene)));
		SceneManager.UnloadSceneAsync(currentScene);
	}

	IEnumerator AsyncLoad(bool single, string newScene) { //if true, sceneLoadMode = Single.  If false, sceneLoadMode = Additive
		AsyncOperation load;

		if(!single) { //if Scene was to be additive
			load = SceneManager.LoadSceneAsync(newScene, LoadSceneMode.Additive);
		} else { //if single
			load = SceneManager.LoadSceneAsync(newScene, LoadSceneMode.Single);
		}
		while(!load.isDone) {
			yield return null;
		}
	}
	IEnumerator WaitForSceneLoad(Scene scene) {
		while(!scene.isLoaded) {
			yield return null;
		}
		Debug.Log("Setting active scene..");
		SceneManager.SetActiveScene(scene);
		print(SceneManager.GetActiveScene().name);
	}
}


