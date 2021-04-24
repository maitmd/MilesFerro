using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item DataBase", menuName = "Assets/Databases/Enemy Database")]
public class NewEnemyDatabase : ScriptableObject {
	public List<NewEnemy> enemies;
}
