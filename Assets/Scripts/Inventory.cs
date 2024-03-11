using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int numItems;
    private int maxItems = 5;
    private Collectable[] inventory;

    // Start is called before the first frame update
    void Start()
    {
        numItems = 0;
        inventory = new Collectable[maxItems];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Adds an item to the inventory
    public void AddItem(Collectable item)
    {
        if (numItems < maxItems)
        {
            inventory[numItems] = item;
            numItems++;
        }
        Debug.Log("Collected " + inventory[0].name);
    }
}
