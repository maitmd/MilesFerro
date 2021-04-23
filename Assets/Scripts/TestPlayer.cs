using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour
{

    public int playerMaxHealth = 100, playerCurrentHealth;
    public int enemyMaxHealth = 150, enemyCurrentHealth;

    public HealthBarUI playerHealthBar;
    public HealthBarUI enemyHealthBar;

    void Start()
    {
        playerCurrentHealth = playerMaxHealth;
        playerHealthBar.SetMaxHealth(playerMaxHealth);

        enemyCurrentHealth = enemyMaxHealth;
        enemyHealthBar.SetMaxHealth(enemyCurrentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){
            PlayerTakeDamage(15);
		}

        if(Input.GetKeyDown(KeyCode.P)){
            EnemyTakeDamage(20);
		}
    }

    void PlayerTakeDamage(int damage){
        playerCurrentHealth -= damage;
        playerHealthBar.SetHealth(playerCurrentHealth);

        if(playerCurrentHealth <= 0){
            print("GAME OVER! ENEMY WINS!!");
		}
    }

    void EnemyTakeDamage(int damage){
        enemyCurrentHealth -= damage;
        enemyHealthBar.SetHealth(enemyCurrentHealth);

        if(enemyCurrentHealth <= 0) {
            print("GAME OVER! PLAYER WINS!!");
        }
    }
}
