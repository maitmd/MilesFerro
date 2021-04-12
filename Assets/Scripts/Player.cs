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
        NewCharMove.setSpeed(getSpeed());
    }
    // Update is called once per frame
    void Update()
    {

    }

    public static string getCurrentScene()
    {
        return currentScene;
    }

    public void switchScene(string name)
    {
        currentScene = name;
        SceneManager.LoadScene(name);
    }
}