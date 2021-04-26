using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private PauseMenu pauseMenu;
	private PlayerAnimation playerAnimation;
	private CheckInteraction checkInteraction;

	private float playerSpeed = 2f;
	private Vector3 lastDirection = new Vector3(0, 0);

	float moveX, moveY;
	LayerMask mask;


	private void Awake() {
		playerAnimation = gameObject.GetComponent<PlayerAnimation>();
		checkInteraction = gameObject.GetComponent<CheckInteraction>();
		pauseMenu = gameObject.GetComponent<PauseMenu>();
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

		if(Input.GetKeyDown(KeyCode.E)) {
			checkInteraction.CheckInteractable();
		}

		if(Input.GetKeyDown(KeyCode.Escape)) {
			pauseMenu.PauseGame();
		}
	}

	private void FixedUpdate() {
		RaycastHit2D[] hit = new RaycastHit2D[0];
		bool isIdle = (moveX == 0 && moveY == 0);
		if(isIdle) {
			playerAnimation.IdleAnimation(lastDirection);
		} else {
			Vector3 moveDirection = new Vector3(moveX, moveY).normalized;
			Vector3 nextPosition = transform.position + moveDirection * playerSpeed * Time.deltaTime;
			mask = ~LayerMask.GetMask("Characters");
			RaycastHit2D raycastHit = Physics2D.Raycast(transform.position, moveDirection, playerSpeed * Time.deltaTime, mask);
			if(raycastHit.collider == null) {
				//nothing hit, can Move
				lastDirection = moveDirection;
				playerAnimation.WalkAnimation(moveDirection);
				transform.position = nextPosition;
			} else {
				playerAnimation.IdleAnimation(lastDirection);
			}
		}
	}

	public void setSpeed(float s) {
		playerSpeed = s;
	}
}