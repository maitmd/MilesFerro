using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    private const int MAXITEMS = 1;
    private string itemName
    {
        get { return itemName; }
        set { itemName = value; }
    }

    private int amount
    {
        get { return amount; }
        set { amount = value; }
    }

    private int id
    {
        get { return id; }
        set { id = value; }
    }

    public int SubtractItem()
    {
        amount--;
        return this.amount;
    }

    public int AddItem()
    {
        amount++;
        return this.amount;
    }

    public static int getMaxItems()
    {
        return MAXITEMS;
    }

    public static Item[] fillItems()
    {
        Item[] items = { new LesserHealing(), new GreaterHealing()};
        return items;
    }

    abstract public void Using(LivingEntity self, LivingEntity targself);
}