using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleHandler : MonoBehaviour
{
    [SerializeField] private LivingEntity[] battlers;
    private float actingBattler;
    private float numBattlers;
    // Start is called before the first frame update
    void Start()
    {
        numBattlers = enemy.getNumBattlers + 1;
    }

    // Update is called once per frame
    void Update()
    {
        Type t;

        if (battlers[actingBattler].Battling())
        {
            if(actingBattler >= numBattlers){actingBattler = 0;}
            else{actingBattler = actingBattler++;}

            t = battlers[actingBattler].getType();
            (t)battlers[actingBattler].battleActions();

            if(battlers[actingBattler].getHealth() <= 0){endBattle(battlers);}
        }

        
    }

    private void endBattle(LivingEntity[] bat)
    {
        Enemy en;
        for(float i = 0; i < bat.GetLength; i++)
        {
            bat[i].BattleStartEnd();
            if (bat[i] is Enemy){
                en = bat[i];
            }
        }

        //return to return scene
    }
}
