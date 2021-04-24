using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Battle {
	public class ActionMenu : MonoBehaviour {

		public bool isOpen_ItemMenu = false;
		public int panelSize = 0;
		public Animator ItemMenuAni;
		public Animator PanelSize;
		ItemMenu itemMenu;

		private void Start() {
			itemMenu = FindObjectOfType<ItemMenu>();
		}

		public void Attack(){  //uses a basic attack

		}

		public void Special(){  //uses a special attack

		}

		public void Items(){  //opens the sub-menu
			if(isOpen_ItemMenu) {
				ItemMenuAni.SetBool("isOpen_ItemMenu", false);
				isOpen_ItemMenu = false;
				itemMenu.SetAllFalse();
				PanelSize.SetInteger("panelSize", 0);
			} else {
				ItemMenuAni.SetBool("isOpen_ItemMenu", true);
				isOpen_ItemMenu = true;
				PanelSize.SetInteger("panelSize", 1);
			}
		}

		public void Run(){  //Exits the battle

		}
	}
}