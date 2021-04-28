using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BattleHandler : MonoBehaviour {
    [SerializeField] private Enemy[] enemyBattlers;
    [SerializeField] private Player[] allyBattlers;

    public HealthBarUI playerHealthBar;
    public HealthBarUI enemyHealthBar;
    [SerializeField] public GameObject playerPanel;
    //[SerializeField] public GameObject enemyName;

    private float numBattlers;
    private LivingEntity actingEntity;

    private bool playerTurn;
    private int allyIndex;
    private int enemyIndex;

    Transitions transitions;
    public Animator animator;

    // Start is called before the first frame update
    void Start() {
        transitions = gameObject.AddComponent<Transitions>();
        enemyHealthBar = GameObject.Find("HealthBar_Enemy").GetComponent<HealthBarUI>();
        fillEnemies(enemyBattlers[0]);
        fillAllies(allyBattlers[0]);
        playerTurn = true;
        allyIndex = 0;
        enemyIndex = 0;
        playerHealthBar.SetMaxHealth(allyBattlers[0].MaxHealth);
        enemyHealthBar.SetMaxHealth(enemyBattlers[0].MaxHealth);
        //enemyName.GetComponent<TextMeshPro>().SetText(enemyBattlers[0].Name);
    }

    // Update is called once per frame
    void Update() {
        if(playerTurn) {
            if(CheckEnd(allyBattlers[0])) {
                //is true
                transitions.BattleEnd(2);
            }
            playerPanel.SetActive(true);
            allyIndex++;
            
        } else {
            if(allyIndex >= allyBattlers.Length) {
                allyIndex = 0;
            }

            if(enemyIndex >= enemyBattlers.Length) {
                enemyIndex = 0;
            }

            
            if(CheckEnd(enemyBattlers[enemyIndex])){
                //is true
                transitions.BattleEnd(1);
			}

            playerPanel.SetActive(false);
            if(!(allyBattlers[allyIndex] is Player)) {
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


    public void NoEscape(LivingEntity entity){
        animator.SetBool("isOpen", true);
        
	}

    public bool CheckEnd(LivingEntity entity){
        if(entity.CurrentHealth <= 0){
            return true;
		}
        return false;
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
        for(int i = 0; i < allyBattlers.Length; i++) {
            playerHealthBar.SetHealth(allyBattlers[i].CurrentHealth);
        }

        for(int i = 0; i < enemyBattlers.Length; i++) {
            enemyHealthBar.SetHealth(enemyBattlers[i].CurrentHealth);
        }

    }
}