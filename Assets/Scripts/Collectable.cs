using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public string name; // set in Inspector
    public string type; // set in Inspector
    public AudioClip song; // set in Inspector

    // Start is called before the first frame update
    void Start()
    {
        //song = Resources.Load<AudioClip>("Harp Music"); // set in Inspector instead
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
