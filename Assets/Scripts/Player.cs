using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : LivingEntity

{

    public float playerSpeed = 1f;

    PlayerAnimation playAni;

    // Start is called before the first frame update
    public void Awake()
    {
        playAni = GetComponentInChildren<PlayerAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = Vector2.ClampMagnitude(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")), 1) * getSpeed();
        Vector2 newPosition = GetComponent<Rigidbody2D>().position + movement * Time.fixedDeltaTime;

        //playAni.setDirection(movement);
        GetComponent<Rigidbody2D>().MovePosition(newPosition);
    }
}