using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckInteraction : MonoBehaviour
{
    public GameObject interactableIcon;
    private GameObject interactClone;
    Vector3 boxSize = new Vector3(5f, 5f);

    public void OpenInteractable() {
        interactClone = Instantiate(interactableIcon);
        interactClone.SetActive(true);
    }

    public void CloseInteractable() {
        Destroy(interactClone);
    }

    public void CheckInteractable() {
        RaycastHit2D[] hits = Physics2D.BoxCastAll(transform.position, boxSize, 0, Vector2.up);

        if(hits.Length > 0) {
            foreach(RaycastHit2D rc in hits) {
                if(rc.transform.GetComponent<Interactable>()) {
                    rc.transform.GetComponent<Interactable>().Interact();
                    return;
                }
            }
        }
    }
}
