using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : LivingEntity
{ 
    public override void battleActions(LivingEntity targ)
    {
    }

    public void standardAttack()
    {

        AttackBonus = 1;
    }

    public void specialAttack()
    {

        AttackBonus = 1;
    }

    public void useItem(int itemID)
    {
        Item it = this.Inventory[itemID];
        it.Using(this);
    }
}