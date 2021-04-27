using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
	
	public abstract void Interact();

	private void OnTriggerEnter2D(Collider2D collision) {
		print(this);
		if(collision.CompareTag("Player")){
			collision.GetComponent<CheckInteraction>().OpenInteractable();
		}
	}

	private void OnTriggerExit2D(Collider2D collision) {
		if(collision.CompareTag("Player")) {
			collision.GetComponent<CheckInteraction>().CloseInteractable(); 
		}
	}
}
