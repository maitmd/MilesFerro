using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingEntity : Entity
{

    [SerializeField] private int maxHealth;
    [SerializeField] private float speed;
    private int currentHealth;
    private ArrayList inventory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setHealth(int newHealth)
    {
        currentHealth = newHealth;
    }

    public int GetHealth()
    {
        return currentHealth;
    }

    public float GetSpeed()
    {
        return speed;
    }
}
