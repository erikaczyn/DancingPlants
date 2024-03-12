using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantFormController : MonoBehaviour
{
    [SerializeField] private BoxCollider2D[] plantformCols;
    [SerializeField] private PlantController plantController;
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (plantController.plantEffect)
        {
            foreach (BoxCollider2D col in plantformCols) {
                col.enabled = true;
            }
        }
        else
        {
            foreach (BoxCollider2D col in plantformCols)
            {
                col.enabled = false;
            }
        }
    }
}
