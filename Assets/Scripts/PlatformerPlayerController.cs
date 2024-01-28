using UnityEngine;

public class PlatformerPlayerController : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float jumpForce = 10f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public GameObject chicken;
    public GameObject box;
    private Rigidbody2D rb;
    private Animator animator;
        
    private bool isGrounded;

    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        if (chicken.activeInHierarchy)
        {
            rb.gravityScale = 3;
        }
        else if (box.activeInHierarchy)
        {
            rb.gravityScale = 7;
        }
        else
        {
            rb.gravityScale = 5;
        }
        // Zeminde olup olmadığını kontrol et
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

        // Oyuncu hareketini kontrol et
        HandleMovement();

        // Zıplama kontrolünü yap
        HandleJump();
        if (!isGrounded)
        {
            animator.SetFloat("Speed", 0);
        }
    }

    void HandleMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontalInput, 0f);
        animator.SetFloat("Speed",Mathf.Abs(horizontalInput));

        transform.Translate(movement * movementSpeed * Time.deltaTime);

        // Yönü kontrol et ve karakteri çevir
        if (horizontalInput > 0)
            transform.localScale = new Vector3(1, 1, 1);
        else if (horizontalInput < 0)
            transform.localScale = new Vector3(-1, 1, 1);
    }

    void HandleJump()
    {
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            // Zeminde ise ve zıplama tuşuna basılmışsa zıpla
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpForce);
        }
    }
}