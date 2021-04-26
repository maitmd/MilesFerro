using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Battle {
    public class ItemMenu : MonoBehaviour {

        public bool isOpen_HealingMenu = false;
        public bool isOpen_SpecialMenu = false;
        public bool isOpen_AttackMenu = false;
        public Animator HealingMenuAni;
        public Animator SpecialMenuAni;
        public Animator AttackMenuAni;
        

        public void HealingItem() { //Opens the Healing Items Menu
            if(isOpen_HealingMenu) {
                HealingMenuAni.SetBool("isOpen_HealingMenu", false);
                isOpen_HealingMenu = false;
            } else {
                HealingMenuAni.SetBool("isOpen_HealingMenu", true);
                SpecialMenuAni.SetBool("isOpen_SpecialMenu", false);
                AttackMenuAni.SetBool("isOpen_AttackMenu", false);
                isOpen_HealingMenu = true;
                isOpen_SpecialMenu = false;
                isOpen_AttackMenu = false;
            }
        }
        public void SpecialItem() { //Opens the Special Items Menu
            if(isOpen_SpecialMenu) {
                SpecialMenuAni.SetBool("isOpen_SpecialMenu", false);
                isOpen_SpecialMenu = false;
            } else {
                HealingMenuAni.SetBool("isOpen_HealingMenu", false);
                SpecialMenuAni.SetBool("isOpen_SpecialMenu", true);
                AttackMenuAni.SetBool("isOpen_AttackMenu", false);
                isOpen_HealingMenu = false;
                isOpen_SpecialMenu = true;
                isOpen_AttackMenu = false;
            }
        }
        public void AttackItems() { //Opens the Attack Items Menu
            if(isOpen_AttackMenu) {
                AttackMenuAni.SetBool("isOpen_AttackMenu", false);
                isOpen_AttackMenu = false;
            } else {
                HealingMenuAni.SetBool("isOpen_HealingMenu", false);
                SpecialMenuAni.SetBool("isOpen_SpecialMenu", false);
                AttackMenuAni.SetBool("isOpen_AttackMenu", true);
                isOpen_HealingMenu = false;
                isOpen_SpecialMenu = false;
                isOpen_AttackMenu = true;
            }
        }

        public void SetAllFalse(){
            SpecialMenuAni.SetBool("isOpen_SpecialMenu", false);
            HealingMenuAni.SetBool("isOpen_HealingMenu", false);
            AttackMenuAni.SetBool("isOpen_AttackMenu", false);
            isOpen_SpecialMenu = false;
            isOpen_AttackMenu = false;
            isOpen_HealingMenu = false;
        }
    }
}