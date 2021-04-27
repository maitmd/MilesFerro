using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SettingMenu : MonoBehaviour
{
    public TMP_Text buttonText;
    public TMP_Dropdown selected;
    private bool isFullscreen;
    Transitions transition;
    public Camera cam;


    public void BackButton() {
        transition.ReturnScene("SettingScene");
    }

	private void Awake() {
        transition = gameObject.AddComponent<Transitions>();
        cam.cullingMask = 5;
    }

	public void Start() {
        if(Screen.fullScreenMode == FullScreenMode.FullScreenWindow) {
			buttonText.SetText("Fullscreen");
            isFullscreen = true;
		} else {
			buttonText.SetText("Windowed");
            isFullscreen = false;
		}

        if(Screen.height == 1080) {
            selected.SetValueWithoutNotify(0);
		} else if(Screen.height == 720) {
            selected.SetValueWithoutNotify(1);
        } else {
            selected.SetValueWithoutNotify(2);
        }
	}

	public void SetFullscreen(){
        if(buttonText.text == "Fullscreen") {
            buttonText.SetText("Windowed");
            Screen.fullScreen = !Screen.fullScreen;
            isFullscreen = false;
        } else if(buttonText.text == "Windowed") {
            buttonText.SetText("Fullscreen");
            Screen.fullScreen = !Screen.fullScreen;
            isFullscreen = true;
        }
    }

    public void SetResolution(){
        /*
        * selected.value = 0   1920 x 1080
        * selected.value = 1   1280 x 720
        * selected.value = 2   720 x 480
        */

        if(selected.value == 0){
            Screen.SetResolution(1920, 1080, isFullscreen);
		}else if(selected.value == 1){
            Screen.SetResolution(1280, 720, isFullscreen);
        } else if(selected.value == 2) {
            Screen.SetResolution(720, 480, isFullscreen);
        }
    }
}