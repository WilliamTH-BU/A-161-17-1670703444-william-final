using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
  
    [SerializeField]  private float jumpForce = 10f;
    [SerializeField] public float MoveSpeed { get; private set; } = 5f;
    [SerializeField] public bool IsInvulnerable { get; private set; } = false;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * MoveSpeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    public void SetMoveSpeed(float amount)
    {
        MoveSpeed += amount;
    }

    public void SetInvulnerability(bool amount)
    {
        IsInvulnerable = amount;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //collision.ApplyEffect();
    }

}

        