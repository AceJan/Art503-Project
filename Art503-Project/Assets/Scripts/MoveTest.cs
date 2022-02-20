using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour
{
	[Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;	// How much to smooth out the movement
  private Vector3 m_Velocity = Vector3.zero;
  public float movementSpeed = 5f;
  public float jumpHeight = 0f;
  public bool isJumping;
  private float moveHorizontal;
  private float moveVertical;
  private Rigidbody2D rb;
    // Start is called before the first frame update
  private void Start()
  {
    rb = GetComponent<Rigidbody2D>(); // gameObject.GetComponent<RigidBody2D>() <- use when code is not directly attached to gameobject

    isJumping = false;
  }

    // Update is called once per frame
    void Update()
    {
      moveHorizontal = Input.GetAxisRaw("Horizontal");
      moveVertical = Input.GetAxisRaw("Vertical");
      if(Input.GetKeyDown("1") || Input.GetKeyUp("1")){
      } else if (Input.GetKeyDown("2") || Input.GetKeyUp("2")){
      } else if (Input.GetKeyDown("3") || Input.GetKeyUp("3")){
      } else if (Input.GetKeyDown("4") || Input.GetKeyUp("4")){
      }
      
    }

    void FixedUpdate()
    {

      
      Vector3 targetVelocity = new Vector2(moveHorizontal * movementSpeed, rb.velocity.y);
      rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);
      // if(isJumping == false && moveHorizontal > 0.1f || moveHorizontal < -0.1f){
      //   rb.AddForce(new Vector2(moveHorizontal * movementSpeed, 0f), ForceMode2D.Impulse);
      // }

      // if(!isJumping && moveHorizontal > 0.1f || moveHorizontal < -0.1f){
      //   rb.velocity = new Vector2(moveHorizontal, 0) * movementSpeed;
      // }

      if(!isJumping && moveVertical > 0.1f){
        rb.AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
      }
    }

    //on ground
    void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.gameObject.tag == "Ground"){
        isJumping = false;
        
      }
    }

    //currently jumping
    void OnTriggerExit2D(Collider2D collision)
    {
      if(collision.gameObject.tag == "Ground"){
        isJumping = true;
      }
    }


}
