using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreaterHealing : Item
{
    private string itemName = "greaterhealing";
    private int amount = 0;
    private float healAmount = .30f;
    private int id = 1;
    private Battle.ItemMenu itemMenu;

	public override void Using(LivingEntity self)
    {
        self.CurrentHealth += (self.MaxHealth * healAmount);
        itemMenu.SetAllFalse();
    }
}
