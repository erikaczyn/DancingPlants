using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int numItems;
    private int maxItems = 5;
    public Collectable[] items;

    // Start is called before the first frame update
    void Start()
    {
        numItems = 0;
        items = new Collectable[maxItems];
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
            items[numItems] = item;
            numItems++;
        }
        Debug.Log("Collected " + items[0].name);
    }
}
