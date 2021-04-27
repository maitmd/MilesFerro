using UnityEngine;

namespace Battle {
	public class HealingItems : MonoBehaviour {
		Items.LesserHealing lesser;
		static public bool isOpen = false;

		private void Start() {
			//lesser = gameObject.AddComponent<Items.LesserHealing>();
		}
		
		public void LesserHealingItems(){ //uses a Lesser Healing Item;
			lesser.UsingItem();
		}

		public void GreaterHealingItems() { //uses a Greater Healing Item;

		}
	}
}