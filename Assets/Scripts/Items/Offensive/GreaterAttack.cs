using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreaterAttack : Item
{
    private string itemName = "greaterattack";
    private int amount = 0;
    private float attackBonus = 1.25f;
    private int id = 3;


    public override void Using(LivingEntity self)
    {
        self.AttackBonus = attackBonus;
    }
}
