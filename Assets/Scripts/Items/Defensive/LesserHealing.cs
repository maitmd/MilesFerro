using UnityEngine;

public class LesserHealing : Item{

    private string itemName = "lesserhealing";
    private int amount = 0;
    private float healAmount = 1.15f;
    private int id = 0;


	public override void Using(LivingEntity entity) {
           entity.setHealth((int)(entity.getMaxHealth() * (healAmount)));
        Debug.Log("it works - lh");
    }

}