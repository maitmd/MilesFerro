using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transitions : MonoBehaviour
{

    public string newScene;

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Door Opened!");
    }
}
