using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{
    public Text buttonText;
    public GameObject button;
    

    public void gameMenu() => SceneManager.LoadScene((int) Scenes.START_MENU);
 

    public void setFullscreen(){
        print("HERE!");
        if(buttonText.text == "Fullscreen") {
            buttonText.text = "Widescreen";
            //set screen as widescreen
            fullscreenMode();
            print("Screen is in Windowed Mode");
        } else if(buttonText.text == "Widescreen"){
            buttonText.text = "Fullscreen";
            //set screen as fullscreen
            fullscreenMode();
            print("Screen is in Fullscreen Mode");
        }
    }

    private void fullscreenMode(){
        Screen.fullScreen = !Screen.fullScreen;
	}
}
