using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField]  private float jumpForce = 10f;
    private bool isInvulnerable = false;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    public void SetMoveSpeed(float amount)
    {
        moveSpeed += amount;
    }

    public void SetInvulnerability(bool amount)
    {
        isInvulnerable = amount;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

}

        