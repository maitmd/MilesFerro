using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
	public static GameController instance;
	public GameObject loadingScreen;

	private void Awake() {
		instance = this;
		SceneManager.LoadSceneAsync((int)Scenes.START_MENU, LoadSceneMode.Additive);
	}

	List<AsyncOperation> scenesLoading = new List<AsyncOperation>();

	public void LoadGame(){
		loadingScreen.gameObject.SetActive(true);
		SceneManager.UnloadSceneAsync((int)Scenes.MANAGER);
		scenesLoading.Add(SceneManager.LoadSceneAsync((int)Scenes.INVENTORY, LoadSceneMode.Additive));
		scenesLoading.Add(SceneManager.LoadSceneAsync((int)Scenes.SETTINGS, LoadSceneMode.Additive));
		scenesLoading.Add(SceneManager.LoadSceneAsync((int)Scenes.LIVING_ROOM, LoadSceneMode.Additive));
		scenesLoading.Add(SceneManager.LoadSceneAsync((int)Scenes.KITCHEN, LoadSceneMode.Additive));

		StartCoroutine(GetSceneLoadProgress());
	}

	public IEnumerator GetSceneLoadProgress(){
		for(int i=0;i<scenesLoading.Count; i++){
			while(!scenesLoading[i].isDone){
				yield return null;
			}
		}
		loadingScreen.gameObject.SetActive(false);
	}
}
