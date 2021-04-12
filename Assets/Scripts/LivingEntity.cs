using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingEntity : Entity
{

    [SerializeField] private int health;
    [SerializeField] private float speed;
    private bool battling = false;
    private ArrayList inventory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getHealth()
    {
        return health;
    }

    public float getSpeed()
    {
        return speed;
    }

    public bool Battling()
    {
        return battling;
    }

    public void setHealth(int newHealth)
    {
        health = newHealth;
    }

    public void BattleStartEnd()
    {
        battling = !battling;
    }
}
