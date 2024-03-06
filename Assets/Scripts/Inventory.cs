using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int numItems;

    // Start is called before the first frame update
    void Start()
    {
        numItems = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Adds an item to the inventory
    public void AddItem(Collectable item)
    {
        numItems++;
    }
}
