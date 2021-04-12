using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCharMove : MonoBehaviour {

    private float playerSpeed = 2f;
    private Vector3 lastDirection = new Vector3(0,0);
    private PlayerAnimation playerAnimation;
    float moveX, moveY;


    private void Awake(){
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
        playerAnimation = gameObject.GetComponent<PlayerAnimation>();
    }

    void Update() {
        float moveConst = 1f;
        moveX = 0f;
        moveY = 0f;
        if (Input.GetKey(KeyCode.W)) {
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
    }

	private void FixedUpdate() {
        RaycastHit2D[] hit = new RaycastHit2D[0];
        bool isIdle = (moveX == 0 && moveY == 0);
        if(isIdle) {
            playerAnimation.idleAnimation(lastDirection);
        } else {
            Vector3 moveDirection = new Vector3(moveX, moveY).normalized;
            Vector3 nextPosition = transform.position + moveDirection * playerSpeed * Time.deltaTime;
            LayerMask mask = LayerMask.GetMask("Characters");
            mask = ~mask;
            RaycastHit2D raycastHit = Physics2D.Raycast(transform.position, moveDirection, playerSpeed * Time.deltaTime, mask);
            //Debug.DrawRay(transform.position, moveDirection, Color.red);
            //Debug.Log(raycastHit.collider);
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

    public void setSpeed(float s)
    {
        playerSpeed = s;
    }
}