using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialBear : Enemy
{
    
    // Start is called before the first frame update
    void Start()
    {
        /*setReturnScene("LivingRoom");
        setBattleScene("TutorialBear");
        setNumBattlers(1f);*/

        ReturnScene = "LivingRoom";
        BattleScene = "TutorialBear";
        NumBattlers = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isBattling())
        {
            //start battle
        }
    }

    new public void battleActions()
    {
        
    }
}