using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    
    private string weaponName;
    private int attack;
    private string description;

    public Weapons(string name, int attack)
    {
        this.weaponName = name;
        this.attack = attack;
    }

    public int getAttack()
    {
        return attack;
    }


}
