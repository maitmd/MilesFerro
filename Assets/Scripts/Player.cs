using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : LivingEntity

{
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
    }

    public void switchScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}