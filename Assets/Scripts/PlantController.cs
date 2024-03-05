using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantController : MonoBehaviour
{
    [SerializeField] private Animator plantAnim;
    [SerializeField] private float animationTime;
    [SerializeField] private float plantDuration;
    private bool opened = false;
    public bool plantEffect = false;
    // Start is called before the first frame update
    void Awake()
    {
        plantAnim.SetTrigger("Close");
        plantAnim.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Song" && !plantAnim.enabled && !opened)
        {
            plantAnim.enabled = true;
            opened = true;
            plantEffect = true;
            plantAnim.SetTrigger("Open");
            StartCoroutine(animStop());
            StartCoroutine(flowerDuration());
        }
    }
    IEnumerator animStop()
    {
        yield return new WaitForSeconds(animationTime);
        plantAnim.enabled = false;
    }
    IEnumerator flowerDuration()
    {
        yield return new WaitForSeconds(plantDuration);
        plantAnim.enabled = true;
        opened = false;
        plantEffect = false;
        plantAnim.SetTrigger("Close");
        StartCoroutine(animStop());
        yield return new WaitForSeconds(animationTime);
        opened = false;
    }
}
