using Unity.VisualScripting;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    [Header("Move Settings")]
    [SerializeField] private float moveSpeed;

    
    [Header("Jump Settings")]
    [SerializeField] private float jumpForce;
    [SerializeField] private Transform sensorGround;
    [SerializeField] private Vector3 sensorSize;
    [SerializeField] private float jumpTimeDuration;
    [SerializeField] private LayerMask layerGround;
    [SerializeField] private float localGravity;

    private Vector2 direction;
    private float currentJumpTime;



    private Rigidbody2D rigidbody2D;
    private SpriteRenderer spriteRenderer;


    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    
    void Update()
    {
        Move();
    }

    void FixedUpdate()
    { 
        OnMove();

    }

    void Move()
    {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;

        if (direction.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (direction.x < 0)
        {
            spriteRenderer.flipX = true;
        }
    }


    void OnMove()
    {
        rigidbody2D.linearVelocity = new Vector2(direction.x, rigidbody2D.linearVelocity.y);
        rigidbody2D.linearVelocity = new Vector2(direction.x, rigidbody2D.linearVelocity.y);

    }

    public int MoveValueX()
    {
        return (int)direction.x;
    }

    public int MoveValueY()
    {
        return (int)direction.y;
    }

    public int JumpValue()
    {
        return (int)rigidbody2D.linearVelocityY;
    }



}
