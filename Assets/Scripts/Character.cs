using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    private string characterName;
    private int health;
    private int armor;

    public Character(string charName, int initHealth, int initArmor)
    {
        characterName = charName;
        health = initHealth;
        armor = initArmor;
    }



    public string getName()
    {
        return characterName;
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
