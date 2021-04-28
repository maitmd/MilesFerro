using UnityEngine;

public class LesserHealing : Item{

    private string itemName = "lesserhealing";
    private int amount = 0;
    private float healAmount = .15f;
    private int id = 0;


	public override void Using(LivingEntity self)
    {
        self.CurrentHealth += ((int)(self.MaxHealth * healAmount));
    }

}