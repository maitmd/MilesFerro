using UnityEngine;

/*
 * Script for creating a new item entity in developer
 * Usage:
 * 
 * RightClick - Create - Assets - Item
 * This will spawn a new Item object - It is recommended that you add the new Item to the database when complete
 */


[CreateAssetMenu(fileName = "New Item", menuName = "Assets/Item")]
public class NewItem : ScriptableObject {
	public string ItemID;           //For database use
	public string ItemName;         //String name of item
	public string Amount;
	[TextArea]
	public string ItemDescription;  //String description of item and properties
	public Sprite ItemSprite;       //Sprite associated with item (for menu visuals)

	public int PrimaryStatNum;      //PlaceHolder for testing.
}


