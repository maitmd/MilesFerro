using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SPBarUI : MonoBehaviour
{
    public Slider spSlider;
    private WaitForSeconds regenTick = new WaitForSeconds(.01f);
    private readonly int maxSP = 100;
    private int currentSP;

    public Button specialButton;

  /*  public static SPBarUI instance;

	public void Awake() {
        ifinstance = this;
	}
*/
	private void Start() {
        spSlider = GameObject.Find("SpecialBar_Player").GetComponent<Slider>();
        specialButton = GameObject.Find("Special").GetComponent<Button>();

        currentSP = 0;
        spSlider.maxValue = maxSP;
        spSlider.value = currentSP;
        ButtonPressed();
	}

    public void setInteractable(){
        if(currentSP == maxSP){
            specialButton.interactable = true;
		}
	}

    public void ButtonPressed(){
        specialButton.interactable = false;
        StartCoroutine(RegenSP());
	}

    private IEnumerator RegenSP(){
        print("Starting Coroutine");
        yield return new WaitForSeconds(1);
        print("waited 1 second");
        while(currentSP < maxSP){
            print(currentSP);
            currentSP += maxSP / 150;
            spSlider.value = currentSP;

            yield return regenTick;
		}
        setInteractable();
	}

}
