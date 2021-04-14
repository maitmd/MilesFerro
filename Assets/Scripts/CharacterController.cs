using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    public GameObject interactableIcon;
    private GameObject interactClone;

    private float playerSpeed = 2f;
    private Vector3 lastDirection = new Vector3(0,0);
    private PlayerAnimation playerAnimation;
    //private InteractAnimation interactAnimation;
    float moveX, moveY;
    float radius = 1;
    LayerMask mask;
    //Collider2D hitCollider = new Collider2D();

    private void Awake(){
        playerAnimation = gameObject.GetComponent<PlayerAnimation>();
        //interactAnimation = new InteractAnimation();
    }

    void Update() {
        float moveConst = 1f;
        moveX = 0f;
        moveY = 0f;

        if(Input.GetKey(KeyCode.W)) {
            moveY = +moveConst;
        }
        if(Input.GetKey(KeyCode.S)) {
            moveY = -moveConst;
        }
        if(Input.GetKey(KeyCode.A)) {
            moveX = -moveConst;
        }
        if(Input.GetKey(KeyCode.D)) {
            moveX = +moveConst;
        }

        if(Input.GetKey(KeyCode.E)){
            checkInteractable();
		}
    }

	private void FixedUpdate() {
        RaycastHit2D[] hit = new RaycastHit2D[0];
        bool isIdle = moveX == 0 && moveY == 0;
        if(isIdle) {
            playerAnimation.idleAnimation(lastDirection);
        } else {
            Vector3 moveDirection = new Vector3(moveX, moveY).normalized;
            Vector3 nextPosition = transform.position + moveDirection * playerSpeed * Time.deltaTime;
            mask = ~LayerMask.GetMask("Characters");
            RaycastHit2D raycastHit = Physics2D.Raycast(transform.position, moveDirection, playerSpeed * Time.deltaTime, mask);
            if(raycastHit.collider == null) {
                //nothing hit, can Move
                lastDirection = moveDirection;
                playerAnimation.walkAnimation(moveDirection);
                transform.position = nextPosition;
            } else {
                playerAnimation.idleAnimation(lastDirection);
            }
		}
    }

    public void openInteractable(){
        print("Text Showing");
        interactClone = Instantiate(interactableIcon);
        interactClone.SetActive(true);
    }

    public void closeInteractable(){
        print("Text Hidden");
        //InteractableIcon.SetActive(false);
        Destroy(interactClone);
    }

    Vector3 boxSize = new Vector3(.3f, 2f);

    private void checkInteractable(){
        RaycastHit2D[] hits = Physics2D.BoxCastAll(transform.position, boxSize, 0, Vector2.up);

        if(hits.Length > 0) {
            foreach(RaycastHit2D rc in hits) {
                if(rc.transform.GetComponent<Interactable>()){
                    rc.transform.GetComponent<Interactable>().Interact();
                    return;
                }
            }
        }
	}



    /*private void inRadius(){
        Vector2 center = transform.position;
        mask = ~LayerMask.GetMask("Characters");
        //print("IN RADIUS!!!");
        Collider2D hitCollider = Physics2D.OverlapCircle(center, radius, mask);
        //print(hitCollider);
        if(hitCollider.tag == "Door") {
            print(hitCollider.name);
		}
        //Debug.DrawRay(center, new Vector3(transform.position.x, transform.position.y), Color.red);
        
        *//*foreach(var hitCollider in hitColliders){
            print(hitCollider.name);
            *//*if(hitCollider.name == "Door") {
                hitCollider.SendMessage("inRadius");
            }*//*
		}*//*
	}*/
}