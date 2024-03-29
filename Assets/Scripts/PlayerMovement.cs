using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Allows the player to move left and right and jump
// Should be attached to the player GameObject
public class PlayerMovement : MonoBehaviour
{
    private bool canMove;
    private bool canJump;
    private float horizontal;
    private float vertical;
    private Rigidbody2D rb;
    private int groundLayer;
    [SerializeField] private float speed = 8.0f;
    [SerializeField] private float jumpSpeed = 7.0f;
    [SerializeField] private float songDuration = 2.0f;
    // Set the start screen in the Inspector
    [SerializeField] private GameObject startScreen;

    [SerializeField] private GameObject songHitbox;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        groundLayer = LayerMask.NameToLayer("Ground");
        Stop();
    }

    // Update is called once per frame
    void Update()
    {
        // Get left/right input
        if (canMove)
        {
            horizontal = Input.GetAxisRaw("Horizontal") * speed;
        } else
        {
            horizontal = rb.velocity.x;
        }

        // Get jump input
        if (canJump && Input.GetButton("Jump"))
        {
            vertical = jumpSpeed;
        } else
        {
            vertical = rb.velocity.y;
        }

        if (transform.position.y < -10.0f)
        {
            startScreen.SetActive(true);
            Stop();
        }
        if (Input.GetButton("Fire1") && canMove && canJump)
        {
            songHitbox.SetActive(true);
            canMove = false;
            canJump = false;
            Stop();
            StartCoroutine("songDisable");
        }
    }
    IEnumerator songDisable()
    {
        yield return new WaitForSeconds(songDuration);
        songHitbox.SetActive(false);
        canMove = true;
        canJump = true;
        rb.WakeUp();
    }
    // FixedUpdate has the frequency of the physics system; it is called every fixed frame-rate frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal, vertical);
    }

    // When a GameObject collides with another GameObject, Unity calls OnTriggerEnter
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check that the collider touches the ground layer
        if (other.gameObject.layer == 3)
        {
            canJump = true;
        }
    }

    // OnTriggerExit is called when the Collider other has stopped touching the trigger
    void OnTriggerExit2D(Collider2D other)
    {
        // Check that the collider has stopped touching the ground layer
        if (other.gameObject.layer == groundLayer)
        {
            canJump = false;
        }
    }

    // Keeps the player from moving
    public void Stop()
    {
        canMove = false;
        canJump = false;
        rb.Sleep();
    }

    // Puts the player back at the start
    public void Reset()
    {
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        canMove = true;
        canJump = true;
        rb.WakeUp();
    }
}
