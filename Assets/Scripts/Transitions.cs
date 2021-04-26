using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transitions : MonoBehaviour
{
	public string newScene;
	public Stack<string> prevScene;
	public string currentScene;

	public Animator animator;

	/*private void OnTriggerEnter2D(Collider2D other) {
        //Debug.Log("Miles Ferro just collided with " + other.name);
        //call GameController and send
        //SceneManager.LoadScene(newScene);
	}*/

	public void inRadius(){
		animator.SetBool("IsOpen", true);
	}

	private void OnTriggerEnter2D(Collider2D collision){
		if (gameObject.CompareTag("Enemy")){
			Time.timeScale = 0f;//stops previous scene while BattleScene is active

			SceneManager.LoadScene(newScene, LoadSceneMode.Additive);
			prevScene.Push(newScene);

			SceneManager.SetActiveScene(SceneManager.GetSceneByName(newScene)); //if this doesn't work properly
			//tell me so I can switch method to Async coroutines
		}
	}

	private void OnTriggerStay2D(Collider2D collision) {
		if (gameObject.CompareTag("Door")) {  //please have any interactable load zone tagged Door for this to work
			if (Input.GetKey(KeyCode.E)) {
				//prevScene = currentScene;
				SceneManager.LoadScene(newScene, LoadSceneMode.Single);
				prevScene.Push(newScene);
				//SceneManager.LoadScene(newScene);

			}
		}
		if (gameObject.CompareTag("Enemy")) {
			//This is for boss/stationary enemies you interact with to battle
			if (Input.GetKey(KeyCode.E)) {
				//prevScene = currentScene;
				SceneManager.LoadScene(newScene, LoadSceneMode.Additive);
				//SceneManager.LoadScene(newScene);
				prevScene.Push(currentScene);
				SceneManager.SetActiveScene(SceneManager.GetSceneByName(newScene)); //if this doesn't work properly
				//tell me so I can switch method to Async coroutines
			}
		}
	}

	public void battleEnd(){  //call proper scene from here
		if (newScene.Equals("Win")){
			SceneManager.SetActiveScene(SceneManager.GetSceneByName(prevScene.Peek()));

			Time.timeScale = 1f;//unpauses previous scene
			SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Battle"));//after destroying BattleScene
			prevScene.Pop();
			//We need to remove the object from Scene
		}
		if (newScene.Equals("Lose")){//change this when we have have a lose scene
			SceneManager.SetActiveScene(SceneManager.GetSceneByName(prevScene.Peek()));
			Time.timeScale = 1f;//unpauses previous scene

			SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Battle"));//after destroying BattleScene
			prevScene.Pop();
		}
		if (newScene.Equals("Escape")){
			SceneManager.SetActiveScene(SceneManager.GetSceneByName(prevScene.Peek()));
			Time.timeScale = 1f;//unpauses previous scene
			SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Battle"));//after destroying BattleScene
			prevScene.Pop();
		}
		//Add other Scenes as necessary
	}

	public void nonGameScene(string newScene, string currentScene, bool multi){
		if(multi){
			SceneManager.LoadScene(newScene, LoadSceneMode.Additive);
			prevScene.Push(currentScene);
		} else {
			SceneManager.LoadScene(newScene, LoadSceneMode.Single);
			prevScene.Push(currentScene);
		}
	}
	//only use for additive scenes
	public void returnScene(string currentScene){
		SceneManager.SetActiveScene(SceneManager.GetSceneByName(prevScene.Pop()));
		SceneManager.UnloadSceneAsync(currentScene);

	}

	private void loadScene(){
	}

	/*IEnumerator AsyncLoad(bool single){ //if true, sceneLoadMode = Single.  If false, sceneLoadMode = Additive
			if (!single){ //if Scene was to be additive
				AsyncOperation load = SceneManager.LoadSceneAsync(newScene, LoadSceneMode.Additive);


				}
			else{ //if not single

				}
			while(!load.isDone){
			}
			SceneManager.setActiveScene(SceneManger.getSceneByName(newScene));
		}*/

}


