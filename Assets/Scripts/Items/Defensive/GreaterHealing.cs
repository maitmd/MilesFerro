using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreaterHealing : Item
{
    private string itemName = "greaterhealing";
    private int amount = 0;
    private float healAmount = .30f;
    private int id = 1;


    public override void Using(LivingEntity self, LivingEntity targ)
    {
        self.CurrentHealth += (self.MaxHealth * healAmount);
    }
}
