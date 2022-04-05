using UnityEngine;

public class Hero : Character
{
    [SerializeField] Transform groundCheckCollider;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] float groundCheckRadius = 0.2f;
    [SerializeField] Transform wallCheckCollider;
    [SerializeField] LayerMask wallLayer;
    [SerializeField] float wallCheckRadius = .2f;
    [SerializeField] Transform teleCheckCollider;
    [SerializeField] LayerMask teleLayer;
    [SerializeField] float teleCheckRadius = .2f;
    [SerializeField] bool isGrounded = false;
    [SerializeField] bool isWall = false;
    [SerializeField] bool isTele = false;
    public SpriteRenderer spriteRenderer; //pick which object you want to change

    //player sprites
    public Sprite archerSprite;
    public Sprite rogueSprite;
    public Sprite tankSprite;
    public Sprite magicianSprite;

    // changes character speed, jump, jumpCount
    public Details archer = new Details(7, 100, 1);
    public Details rogue = new Details(7, 75, 2);
    public Details tank = new Details(5, 80, 1);
    public Details magician = new Details(7, 2.77f, 0);

    public static Rigidbody2D rb;
    private float moveHorizontal;
    private Vector3 m_Velocity = Vector3.zero;
    private bool facingRight = true;

    //[SerializedField] just means that that variable will appear in the inspector column (normally on the right side)
    //[Range(0, .3f)] is a slider ranging from 0 to .3f
    [Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;	// How much to smooth out the movement
    public static int heroNumber = 1;
    private int currentJumpCount;



    private void Start()
    {
        //gets the rigid body 2D of whatever this code is applied to
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        rb.sharedMaterial.friction = 1f;
        heroNumber = 1; //set to one whenever play scene is called
    }

    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal"); //use left/right arrow keys to move

        if(!PauseMenu.isPaused){
            if(facingRight == false && moveHorizontal > 0) Flip();
            else if (facingRight == true && moveHorizontal < 0) Flip();
        }

        // press 1, 2, 3, or 4 to change characters
        if(isGrounded){
            if(Input.GetKeyDown("1") || Input.GetKeyUp("1")){
            heroNumber = 1;
            spriteRenderer.sprite = archerSprite;
            rb.sharedMaterial.friction = 1f;
        } else if (Input.GetKeyDown("2") || Input.GetKeyUp("2")){
            heroNumber = 2;
            spriteRenderer.sprite = rogueSprite;
            rb.sharedMaterial.friction = 0f;
        } else if (Input.GetKeyDown("3") || Input.GetKeyUp("3")){
            heroNumber = 3;
            spriteRenderer.sprite = tankSprite;
            rb.sharedMaterial.friction = 0f;
        } else if (Input.GetKeyDown("4") || Input.GetKeyUp("4")){
            heroNumber = 4;
            spriteRenderer.sprite = magicianSprite;
            rb.sharedMaterial.friction = 0f;
        }


        }
        //on the ground and not in the air
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
        //wall jump
        //resets jump counter for archer when attached to a wall
        if(heroNumber == 1 && !isGrounded && isWall) currentJumpCount = archer.jumpCounter;
        //Jumping
        if((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)) && currentJumpCount > 0 && heroNumber != 4){
            //Debug.Log(currentJumpCount);
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
            }
        } 
        //teleport if teleport collider is not colliding in anything
        //tele up
        else if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && currentJumpCount == 0 && heroNumber == 4){
            teleCheckCollider.transform.localPosition = new Vector3(0, magician.jumpHt, 0);
        }  
        //tele left/right
        else if ( (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) &&
        currentJumpCount == 0 && heroNumber == 4){
            teleCheckCollider.transform.localPosition = new Vector3(magician.jumpHt, .1f, 0);
        }
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) &&
        currentJumpCount == 0 && heroNumber == 4){
            teleCheckCollider.transform.localPosition = new Vector3(magician.jumpHt, .1f, 0);
        }
         else if (heroNumber == 4 && Input.GetKey(KeyCode.Space)){
            if(!isTele && isGrounded){
                if(Input.GetKeyDown(KeyCode.Space)) {
                    rb.transform.position = teleCheckCollider.position;
                    Debug.Log(teleCheckCollider.position);
                }
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
        CheckWallLayer();
        CheckTeleport();
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector2 scaler = rb.transform.localScale;
        scaler.x *= -1;
        rb.transform.localScale = scaler;

    }
    //checks if the player is touching Ground layer
    void CheckGroundLayer()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckCollider.position, groundCheckRadius, groundLayer);
    }

    void CheckWallLayer()
    {
        isWall = Physics2D.OverlapCircle(wallCheckCollider.position, wallCheckRadius, wallLayer);
    }

    void CheckTeleport(){
        isTele = Physics2D.OverlapCircle(teleCheckCollider.position, teleCheckRadius, teleLayer);
    }
}
