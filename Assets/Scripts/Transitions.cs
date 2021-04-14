using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transitions : Interactable
{
    public string newScene;
	public string prevScene = "";
	public string currentScene = "";

	public Animator animator;

	/*private void OnTriggerEnter2D(Collider2D other) {
        //Debug.Log("Miles Ferro just collided with " + other.name);
        //call GameController and send 
        //SceneManager.LoadScene(newScene);
	}*/

	public void inRadius(){
		animator.SetBool("IsOpen", true);
	}

	private void OnTriggerStay2D(Collider2D collision) {
		if(Input.GetKey(KeyCode.E)){
			prevScene = currentScene;
			SceneManager.LoadSceneAsync(newScene);
			//SceneManager.LoadScene(newScene);

			SceneManager.SetActiveScene(SceneManager.GetSceneByName("Kitchen"));
			Debug.Log(SceneManager.GetActiveScene().name);
		}
	}

	private void loadScene(){
	}

	public override void Interact() {
		
	}

}
