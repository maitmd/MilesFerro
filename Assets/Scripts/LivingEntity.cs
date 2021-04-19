using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingEntity : Entity
{

    [SerializeField] private int health;
    [SerializeField] private float speed;
    private ArrayList inventory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetHealth()
    {
        return health;
    }

    public float GetSpeed()
    {
        return speed;
    }

    public void SetHealth(int newHealth)
    {
        health = newHealth;
    }
}
