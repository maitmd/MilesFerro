using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{

    public string mainMenu;
    private bool isFullscreen = false;
    

    public void gameMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }

    public void setFullscreen(){
        if(!isFullscreen){
            
		}
	}

    public void textChanger(){
        string fullscreenButton = GameObject.FindWithTag("FullscreenButton").GetComponentInChildren<Text>().text;
        if(fullscreenButton == "Fullscreen"){
            fullscreenButton = "Windowed";
		}else{
            fullscreenButton = "Windowed";
        }

	}
}
