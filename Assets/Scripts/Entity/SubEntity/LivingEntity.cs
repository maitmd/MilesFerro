using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LivingEntity : Entity
{

    [SerializeField] private int maxHealth;
    [SerializeField] private float speed;
    private int currentHealth;
    private ArrayList inventory;
    private bool battling = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /*public LivingEntity(int maxHP, int sp)
    {
        inventory = new ArrayList<Item>();
        maxHealth = maxHP;
        speed = sp;
        currentHealth = maxHP;

    }*/

    public void setHealth(int newHealth)
    {
        currentHealth = newHealth;
    }

    public void setMaxHealth(int max)
    {
        maxHealth = max;
    }

    public void setSpeed(float sp)
    {
        speed = sp;
    }

    /*public void addItem(Item it)
    {
        inventory.Add(it);
    }*/

    public int getMaxHealth()
    {
        return maxHealth;
    }

    public int getHealth()
    {
        return currentHealth;
    }

    public float getSpeed()
    {
        return speed;
    }

    public bool isBattling()
    {
        return battling;
    }

    public void battleStartEnd()
    {
        battling = !battling;
    }

    public abstract void battleActions();
}
