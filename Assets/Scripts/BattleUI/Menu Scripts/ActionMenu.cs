using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Battle {
	public class ActionMenu : MonoBehaviour {

		public bool isOpen_ItemMenu = false;
		public Animator ItemMenuAni;
		ItemMenu itemMenu;

		private void Start() {
			itemMenu = FindObjectOfType<ItemMenu>();
		}

		public void Attack(){  //uses a basic attack
			CloseItems();
		}

		public void Special(){  //uses a special attack
			CloseItems();
		}

		public void Items(){  //opens the sub-menu
			if(isOpen_ItemMenu) {
				ItemMenuAni.SetBool("isOpen_ItemMenu", false);
				isOpen_ItemMenu = false;
				itemMenu.SetAllFalse();
			} else {
				ItemMenuAni.SetBool("isOpen_ItemMenu", true);
				isOpen_ItemMenu = true;
			}
		}

		public void CloseItems(){
			if(isOpen_ItemMenu){
				ItemMenuAni.SetBool("isOpen_ItemMenu", false);
				isOpen_ItemMenu = false;
				itemMenu.SetAllFalse();
			} else{
				return;
			}
		}

		public void Run(){  //Exits the battle
			CloseItems();
		}
	}
}