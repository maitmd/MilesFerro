using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BattleHandler : MonoBehaviour
{
    [SerializeField] private Enemy[] enemyBattlers;
    [SerializeField] private Player[] allyBattlers;

    public HealthBarUI playerHealthBar;
    public HealthBarUI enemyHealthBar;
    [SerializeField] public GameObject playerPanel;
    [SerializeField] public GameObject enemyName;

    private float numBattlers;
    private LivingEntity actingEntity;

    private bool playerTurn;
    private int allyIndex;
    private int enemyIndex;

    // Start is called before the first frame update
    void Start()
    {
        fillEnemies(enemyBattlers[0]);
        fillAllies(allyBattlers[0]);
        allyIndex = 0;
        enemyIndex = 0;
        playerHealthBar.SetMaxHealth(allyBattlers[0].MaxHealth);
        enemyHealthBar.SetMaxHealth(enemyBattlers[0].MaxHealth);
        enemyName.GetComponent<TextMeshPro>().SetText(enemyBattlers[0].Name);
        playerTurn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTurn)
        {
            playerPanel.SetActive(true);
            allyIndex++;
        }
        else
        {
            if(allyIndex >= allyBattlers.Length)
            {
                allyIndex = 0;
            }

            if (enemyIndex >= enemyBattlers.Length)
            {
                enemyIndex = 0;
            }

            playerPanel.SetActive(false);
            if (!(allyBattlers[allyIndex] is Player))
            {
                float randAlly = Random.Range(0f, ((float)(enemyBattlers.Length)));
                allyBattlers[allyIndex].battleActions(enemyBattlers[(int)randAlly]);
            }

            float randEnemy = Random.Range(0f, ((float)(allyBattlers.Length)));
            enemyBattlers[enemyIndex].battleActions(allyBattlers[(int)randEnemy]);

            switchTurn();

            enemyIndex++;
            allyIndex++;
        }

        updateHealth();
    }

    public void fillEnemies(Enemy en)
    {
        //pull from stored arrayList of enemies in Enemy [Not implemented in Enemy]
    }

    public void fillAllies(Player pl)
    {
        
        //possibly in the future you will have allies in the game I would suggest making an Ally class and derive Player from it
        //additionally just like Enemies will store their mob in the main enemy have the player store allies in an arraylist as well
    }

    public void switchTurn()
    {
        playerTurn = !playerTurn;
    }

    public void updateHealth()
    {
        for(int i = 0; i < allyIndex; i++)
        {
            playerHealthBar.SetHealth(allyBattlers[i].CurrentHealth);
        }

        for (int i = 0; i < enemyIndex; i++)
        {
            enemyHealthBar.SetHealth(enemyBattlers[i].CurrentHealth);
        }
    }
}
