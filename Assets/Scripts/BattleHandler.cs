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
updateHealth();
    }

    public void fillEnemies(Enemy en) {
	//pull from stored arrayList of enemies in Enemy [Not implemented in Enemy]
}

public void fillAllies(Player pl) {

	//possibly in the future you will have allies in the game I would suggest making an Ally class and derive Player from it
	//additionally just like Enemies will store their mob in the main enemy have the player store allies in an arraylist as well
}

public void switchTurn() {
	playerTurn = !playerTurn;
}

public void updateHealth() {
	for(int i = 0; i < allyIndex; i++) {
		playerHealthBar.SetHealth(allyBattlers[i].CurrentHealth);
	}

	for(int i = 0; i < enemyIndex; i++) {
		enemyHealthBar.SetHealth(enemyBattlers[i].CurrentHealth);
	}

}
}
