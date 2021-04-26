using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : LivingEntity
{ 

    // Start is called before the first frame update
    public void Awake()
    {

    }

    public void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
    }

    public override void battleActions()
    {
        
    }

    public void standardAttack()
    {

    }

    public void useItem(int itemID)
    {
        Item it = getInventory()[itemID];
        it.Using(this);
    }
}