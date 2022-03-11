using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : Character
{ 
    [SerializeField] Transform groundCheckCollider;
    [SerializeField] LayerMask groundLayer;

    [SerializeField] float groundCheckRadius = 0.2f;
    [SerializeField] bool isGrounded = false;
    public SpriteRenderer spriteRenderer; //pick which object you want to change

    //player sprites
    public Sprite archerSprite;
    public Sprite rogueSprite;
    public Sprite tankSprite;
    public Sprite magicianSprite;
    

    // changes character speed/jump
    public Details archer = new Details(10, 80, 1);
    public Details rogue = new Details(10, 80, 2);
    public Details tank = new Details(5, 40, 1);
    public Details magician = new Details(7, 60, 1);

    private Rigidbody2D rb;
    private float moveHorizontal;
    private Vector3 m_Velocity = Vector3.zero;
    private bool facingRight = true;

    //[SerializedField] just means that that variable will appear in the inspector column (normally on the right side)
    //[Range(0, .3f)] is a slider ranging from 0 to .3f
    [Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;	// How much to smooth out the movement
    private int heroNumber = 1;
    private int currentJumpCount;



    private void Start()
    {
        //gets the rigid body 2D of whatever this code is applied to
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal"); //use left/right arrow keys to move

        if(facingRight == false && moveHorizontal > 0) Flip();
        else if (facingRight == true && moveHorizontal < 0) Flip();
        // press 1, 2, 3, or 4 to change speed
        if(Input.GetKeyDown("1") || Input.GetKeyUp("1")){
            heroNumber = 1;
            spriteRenderer.sprite = archerSprite;
            Debug.Log(heroNumber);
        } else if (Input.GetKeyDown("2") || Input.GetKeyUp("2")){
            heroNumber = 2;
            spriteRenderer.sprite = rogueSprite;
            Debug.Log(heroNumber);
        } else if (Input.GetKeyDown("3") || Input.GetKeyUp("3")){
            heroNumber = 3;
            spriteRenderer.sprite = tankSprite;
            Debug.Log(heroNumber);
        } else if (Input.GetKeyDown("4") || Input.GetKeyUp("4")){
            heroNumber = 4;
            spriteRenderer.sprite = magicianSprite;
            Debug.Log(heroNumber);
        }

        if(isGrounded == true && rb.velocity.y == 0){
            if(heroNumber == 1){
                currentJumpCount = archer.jumpCounter;
            } else if(heroNumber == 2){
                currentJumpCount = rogue.jumpCounter;
            } else if(heroNumber == 3){
                currentJumpCount = tank.jumpCounter;
            } else if(heroNumber == 4){
                currentJumpCount = magician.jumpCounter;
            }
        }
        //pressing up arrow key
        if(Input.GetKeyDown(KeyCode.UpArrow) && currentJumpCount > 0){
            Debug.Log(currentJumpCount);
            if(heroNumber == 1){
                rb.AddForce(new Vector2(0f, archer.jumpHt), ForceMode2D.Impulse);
                currentJumpCount --;
            } else if(heroNumber == 2){
                if(currentJumpCount == 2){
                    rb.AddForce(new Vector2(0f, rogue.jumpHt), ForceMode2D.Impulse);    
                } else if (currentJumpCount == 1){
                    rb.AddForce(new Vector2(0f, rogue.jumpHt), ForceMode2D.Impulse);    
                }
                
                currentJumpCount --;
            } else if(heroNumber == 3){
                rb.AddForce(new Vector2(0f, tank.jumpHt), ForceMode2D.Impulse);
                currentJumpCount --;
            } else if(heroNumber == 4){
                rb.AddForce(new Vector2(0f, magician.jumpHt), ForceMode2D.Impulse);
                currentJumpCount --;
            }
            
        }
        
    }
    
    void FixedUpdate()
    {
        //movement for the heroes
        if(heroNumber == 1){
            Vector3 targetVelocity = new Vector2(moveHorizontal * archer.moveSp, rb.velocity.y);
            rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);
        } else if (heroNumber == 2){
            Vector3 targetVelocity = new Vector2(moveHorizontal * rogue.moveSp, rb.velocity.y);
            rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);
        } else if (heroNumber == 3){
            Vector3 targetVelocity = new Vector2(moveHorizontal * tank.moveSp, rb.velocity.y);
            rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);
        } else if (heroNumber == 4){
            Vector3 targetVelocity = new Vector2(moveHorizontal * magician.moveSp, rb.velocity.y);
            rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);
        }
        CheckGroundLayer();
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector2 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
    //checks if the player is touching Ground layer
    void CheckGroundLayer()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckCollider.position, groundCheckRadius, groundLayer);
    }
}
