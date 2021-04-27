using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Battle {
    public class BattleHandler : MonoBehaviour {
        [SerializeField] private LivingEntity[] battlers;
        private int actingBattler;
        private float numBattlers;
        // Start is called before the first frame update
        void Start() {
            for(int i = 0; i < battlers.Length; i++) {
                if(battlers[i] is Enemy) {
                    numBattlers = ((Enemy)battlers[i]).NumBattlers;
                    break;
                }
            }
            actingBattler = 0;
        }

        // Update is called once per frame
        void Update() {
            if(battlers[actingBattler].isBattling()) {
                if(actingBattler >= numBattlers) { actingBattler = 0; } else { actingBattler += 1; }

                if(battlers[actingBattler] is Player) {
                    ((Player)battlers[actingBattler]).battleActions();
                } else {
                    ((Enemy)battlers[actingBattler]).battleActions();
                }

                if(battlers[actingBattler].getHealth() <= 0) { endBattle(battlers); }
            }


        }

        private void endBattle(LivingEntity[] bat) {
            Enemy en;
            for(int i = 0; i < bat.Length; i++) {
                bat[i].battleStartEnd();
                if(bat[i] is Enemy) {
                    en = (Enemy)bat[i];
                }
            }

            //return to return scene
        }
    }
}