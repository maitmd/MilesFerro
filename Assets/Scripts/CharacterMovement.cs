using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    public float playerSpeed = 1f;
    Rigidbody2D rbody;

    PlayerAnimation playAni;

    // Start is called before the first frame update
    public void Awake() {
        rbody = GetComponent<Rigidbody2D>();
        playAni = GetComponentInChildren<PlayerAnimation>();
    }

    // Update is called once per frame
    void Update() {
        Vector2 currentPosition = rbody.position;

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 input = new Vector2(horizontal, vertical);

        input = Vector2.ClampMagnitude(input, 1);
        Vector2 movement = input * playerSpeed;

        Vector2 newPosition = currentPosition + movement * Time.fixedDeltaTime;
        playAni.setDirection(movement);
        rbody.MovePosition(newPosition);
    }
}