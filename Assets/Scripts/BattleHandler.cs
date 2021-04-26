using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleHandler : MonoBehaviour
{
    [SerializeField] private Enemy[] enemyBattlers;
    [SerializeField] private Player[] allyBattlers;
    private float numBattlers;
    private LivingEntity actingEntity;
    private bool playerTurn;

    // Start is called before the first frame update
    void Start()
    {
        fillEnemies(enemyBattlers[0]);
        fillAllies(allyBattlers[0]);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void endBattle(LivingEntity[] bat)
    {
        Enemy en;
        for(int i = 0; i < bat.Length; i++)
        {
            bat[i].battleStartEnd();
            if (bat[i] is Enemy){
                en = (Enemy)bat[i];
            }
        }

        //return to return scene
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
}
