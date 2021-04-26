using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item{
    private const int MAXITEMS = 1;
    private string itemName;
    private int amount;
    private int id;

    public int SubtractItem()
    {
        amount--;
        return getAmount();
    }

    public int AddItem()
    {
        amount++;
        return getAmount();
    }

    public void setItemName(string itN)
    {
        itemName = itN;
    }

    public void setAmount(int i)
    {
        amount = i;
    }
    public int getAmount()
    {
        return amount;
    }

    public void setID(int i)
    {
        id = i;
    }
    
    public int getID()
    {
        return id;
    }

    public static int getMaxItems()
    {
        return MAXITEMS;
    }

    public static Item[] fillItems()
    {
        Item[] items = { new LesserHealing() };
        return items;
    }

    abstract public void Using(LivingEntity entity);
}