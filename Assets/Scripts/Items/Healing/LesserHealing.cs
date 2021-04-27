using UnityEngine;

namespace Items {
	public class LesserHealing {

		Battle.TestPlayer tester = new Battle.TestPlayer();
		public string itemName = "Lesser Healing";
		public int amount = 0;
		public float gainLife = .15f; //percentage of life gained
		public int intGainLife = 15;

		public void UsingItem() {
			Debug.Log("Using a " + itemName);
			SubtractItem();
			tester.PlayerGainLife(intGainLife);
			//Debug.Log(tester.GetComponent<Battle.TestPlayer>());
			//tester.GetComponent<Battle.TestPlayer>().PlayerGainLife(intGainLife);
		}

		public void SubtractItem() {
			amount--;
		}

		public void AddingItem() {
			amount++;
		}
	}
}