using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item DataBase", menuName = "Assets/Databases/Item Database")]
public class ItemDataBase : ScriptableObject {
	public List<NewItem> dataBase;
}
