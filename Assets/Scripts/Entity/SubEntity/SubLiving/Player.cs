using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : LivingEntity{

    public float playerSpeed = 1f;

    PlayerAnimation playAni;

    // Start is called before the first frame update
    public void Awake()
    {

    }

    public void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 movement = Vector2.ClampMagnitude(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")), 1) * playerSpeed * Time.deltaTime;
        Vector2 newPosition = GetComponent<Rigidbody2D>().position + movement * Time.fixedDeltaTime;
    }

    public void switchScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public override void battleActions()
    {
        //stuff
    }
}