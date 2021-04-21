using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : NPC
{
    private string battleScene;
    private string returnScene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void startBattle()
    {
        SceneManager.LoadScene(getBattleScene());
    }

    public void endBattle()
    {
        SceneManager.LoadScene(getReturnScene());
    }

    public string getBattleScene()
    {
        return battleScene;
    }

    public string getReturnScene()
    {
        return returnScene;
    }

    public void setBattleScene(string b)
    {
        battleScene = b;
    }

    public void setReturnScene(string r)
    {
        returnScene = r;
    }
}
