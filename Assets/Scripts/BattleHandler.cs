using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleHandler : MonoBehaviour
{
    [SerializeField] private Enemy enemy;
    [SerializeField] private Player player;
    private string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(sceneName);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("hello world");
    }

    public void setScene(string sceneName)
    {
        this.sceneName = sceneName;
    }
}
