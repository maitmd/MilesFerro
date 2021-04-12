using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeggingsGuardian : Enemy
{
    private BattleHandler battle;
    private string sceneName = "LeggingsGuardian";
    private string returnScene;
    // Start is called before the first frame update
    void Start()
    {
        battle.setScene(sceneName);
        battle = GetComponent<BattleHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startBattle()
    {
        returnScene = Player.getCurrentScene();
        battle.enabled = true;
    }
}
