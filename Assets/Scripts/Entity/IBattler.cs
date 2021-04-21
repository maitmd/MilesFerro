using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IBattler
{
    private bool battling = false;

    public bool Battling()
    {
        return battling;
    }


    public void BattleStartEnd()
    {
        battling = !battling;
    }

    public abstract void battleActions();
}
