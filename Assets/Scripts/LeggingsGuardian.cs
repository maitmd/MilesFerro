using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeggingsGuardian : Enemy
{
    
    // Start is called before the first frame update
    void Start()
    {
        setReturnScene("Kitchen");
        setBattleScene("LeggingsGuardian");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.Battling())
        {
            BattleHandler battle = GetComponent<BattleHandler>();
            startBattle();
        }
    }
}
