using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialBear : Enemy
{
    
    // Start is called before the first frame update
    void Start()
    {
        this.ReturnScene = "LivingRoom";
        this.BattlePrefab = "TutorialBear";
        this.NumBattlers = 1f;
        this.Name = "TutorialBear";
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isBattling())
        {
            //start battle
        }
    }

    public override void battleActions(LivingEntity targ)
    {
        
    }
}
