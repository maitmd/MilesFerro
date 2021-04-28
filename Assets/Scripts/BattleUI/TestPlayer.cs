using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Battle {
    public class TestPlayer : MonoBehaviour {

        public int playerMaxHealth = 100, playerCurrentHealth;
        public int enemyMaxHealth = 150, enemyCurrentHealth;

        public HealthBarUI playerHealthBar;
        public HealthBarUI enemyHealthBar;

        void Start() {
            
            playerCurrentHealth = playerMaxHealth;
            playerHealthBar.SetMaxHealth(playerMaxHealth);

            enemyCurrentHealth = enemyMaxHealth;
            enemyHealthBar.SetMaxHealth(enemyCurrentHealth);
        }

        // Update is called once per frame
        void Update() {
            if(Input.GetKeyDown(KeyCode.Q)) {
                PlayerTakeDamage(15);
            }

            if(Input.GetKeyDown(KeyCode.P)) {
                EnemyTakeDamage(20);
            }
        }

        void PlayerTakeDamage(int damage) {
            playerCurrentHealth -= damage;
            playerHealthBar.SetHealth(playerCurrentHealth);
            print(playerCurrentHealth + " Life");
            if(playerCurrentHealth <= 0) {
                print("GAME OVER! ENEMY WINS!!");
            }
        }

		public void PlayerGainLife(float lifeGain) {
			float percentageGained = playerMaxHealth * lifeGain;
			//print(percentageGained + " Life Gained Before");
			playerCurrentHealth += (int)Mathf.Ceil(percentageGained);
			//print(percentageGained + " Life Gained After");
			playerHealthBar.SetHealth(playerCurrentHealth);
		}

		public void PlayerGainLife(int lifeGain){
            print(playerCurrentHealth + " Life Before");
            playerCurrentHealth += lifeGain;
            print(playerCurrentHealth + " Life After");
            playerHealthBar.SetHealth(playerCurrentHealth);
        }

        void EnemyTakeDamage(int damage) {
            enemyCurrentHealth -= damage;
            enemyHealthBar.SetHealth(enemyCurrentHealth);

            if(enemyCurrentHealth <= 0) {
                print("GAME OVER! PLAYER WINS!!");
            }
        }
    }
}
