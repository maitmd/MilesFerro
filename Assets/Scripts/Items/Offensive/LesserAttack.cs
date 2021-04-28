using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LesserAttack : Item
{
    private string itemName = "lesserattack";
    private int amount = 0;
    private float attackBonus = 1.15f;
    private int id = 2;


    public override void Using(LivingEntity self, LivingEntity targ)
    {
        self.AttackBonus = attackBonus;
    }
}
