using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : LivingEntity
{
    private string battlePrefab;
    private string returnScene;
    private float numBattlers;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public string getBattlePrefab()
    {
        return battlePrefab;
    }

    public string getReturnScene()
    {
        return returnScene;
    }
    public float getNumBattlers()
    {
        return numBattlers;
    }
	public void setBattlePrefab(string b) {
        battlePrefab = b;
	}

    public void setReturnScene(string r)
    {
        returnScene = r;
    }
    public void setNumBattlers(float n)
    {
        numBattlers = n;
    }

    public override void battleActions() { }
}