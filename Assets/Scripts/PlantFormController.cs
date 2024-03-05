using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantFormController : MonoBehaviour
{
    [SerializeField] private BoxCollider2D plantformCol;
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
            plantformCol.enabled = true;
        }
        else
        {
            plantformCol.enabled = false;
        }
    }
}
