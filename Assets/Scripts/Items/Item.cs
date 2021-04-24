using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BattleItems {
	public abstract class Item : MonoBehaviour{
		
		public string itemName;
		public int amount;

		protected Item(string item, int number){
			this.itemName = item;
			this.amount = number;
		}

		abstract public void Using();
		abstract public void SubtractItem();
		abstract public void AddingItem();

	}
}