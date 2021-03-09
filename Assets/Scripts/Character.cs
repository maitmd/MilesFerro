using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    private string name;
    private int health;
    private int armor;

    public Character(string charName, int initHealth, int initArmor)
    {
        name = charName;
        health = initHealth;
        armor = initArmor;
    }



    public string getName()
    {
        return name;
    }

    public int getHealth()
    {
        return health;
    }

    public void setHealth(int newHealth)
    {
        health = newHealth;
    }

    public int getArmor()
    {
        return armor;
    }

    public void setArmor(int newArmor)
    {
        armor = newArmor;
    }


}
