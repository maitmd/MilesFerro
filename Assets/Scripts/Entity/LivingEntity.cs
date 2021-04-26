using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LivingEntity : Entity
{

    [SerializeField] private int maxHealth;
    [SerializeField] private float speed;
    private int currentHealth;
    private Item[] inventory = new Item[Item.getMaxItems()];
    private bool battling = false;

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

    public void addItem(Item it)
    {
        inventory[it.getID()].AddItem();
    }

    public void removeItem(Item it)
    {
        Item temp = inventory[it.getID()];
        if (temp.getAmount() <= 0)
        {
            temp.setAmount(0);
        } else
        {
            temp.SubtractItem();
        }
    }

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

    public Item[] getInventory()
    {
        return inventory;
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
