using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Enemy Data Class

[CreateAssetMenu(fileName = "New Enemy", menuName = "Assets/Enemy")]
public class NewEnemy : ScriptableObject {
	public string EnemyID;
	public string EnemyName;
	public Sprite EnemySprite;

	public int MaxHealth;       //Inital and Maximum health.
	public int Health;          //Current Health - Set to max upon spawn.
	public int Speed;           //Enemy Speed.

	public int AttackDamage;    //Damage value for basic attack.
	public double AttackResistance; //Multiplier - Meant to affect the amount of damage the opponent actually takes.
									//Attack Amount * AttackResistance = Actual Damage Done (rounded).
}
