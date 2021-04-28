using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : LivingEntity
{ 
    public override void battleActions(LivingEntity targ)
    {
    }

    public void standardAttack(Enemy targ)
    {
        float plusOrMinus = Random.Range(0f, 10f);
        targ.CurrentHealth -= (10 + plusOrMinus) * AttackBonus;
        AttackBonus = 1;
    }

    public void specialAttack(Enemy targ)
    {
        float plusOrMinus = Random.Range(0f, 20f);
        targ.CurrentHealth -= (30 + plusOrMinus) * AttackBonus;
        AttackBonus = 1;
    }

    public void useItem(int itemID, Enemy targ)
    {
        Item it = this.Inventory[itemID];
        it.Using(this, targ);
    }
}