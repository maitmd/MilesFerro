using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LivingEntity : Entity
{
    private bool battling = false;

    [SerializeField] private float maxHealth;
    public float MaxHealth
    {
        get { return maxHealth; }
        set { maxHealth = value; }
    }

    private float attackBonus = 1;
    public float AttackBonus
    {
        get { return attackBonus; }
        set { attackBonus = value; }
    }

    private float attackValue = 10f;
    public float AttackValue
    {
        get { return attackValue; }
        set { attackValue = value; }
    }

    [SerializeField] private float currentHealth;
    public float CurrentHealth
    {
        get { return currentHealth; }
        set { currentHealth = value; }
    }

    private Item[] inventory;
    public Item[] Inventory
    {
        get { 
                if(inventory[0] = null){
                    inventory = Item.fillItems();
                }
                return inventory; 
             }
        set { inventory = Item.fillItems(); }
    }

    public void battleStartEnd()
    {
        battling = !battling;
    }

    public bool isBattling()
    {
        return battling;
    }

    public abstract void battleActions(LivingEntity targ);
}
