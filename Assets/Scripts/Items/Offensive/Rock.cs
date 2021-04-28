using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Item
{
    private string itemName = "rock";
    private int amount = 0;
    private float damage = 20;
    private int id = 4;


    public override void Using(LivingEntity self, LivingEntity targ)
    {
        float plusOrMinus = Random.Range(0f, 20f);
        targ.CurrentHealth -= (30 + plusOrMinus) * self.AttackBonus;
        self.AttackBonus = 1;
    }
}
