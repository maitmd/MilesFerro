using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : LivingEntity
{
    private string battlePrefab;
    public string BattlePrefab
    {
        get { return battlePrefab; }
        set { battlePrefab = value; }
    }

    private string returnScene;
    public string ReturnScene
    {
        get { return returnScene; }
        set { returnScene = value; }
    }

    private float numBattlers;
    public float NumBattlers
    {
        get { return numBattlers; }
        set { numBattlers = value; }
    }

    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public override void battleActions(LivingEntity targ) { }
}
