using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

  public float movementSpeed = 5f;
  public float jumpHeight = 15f;
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
    }

    void FixedUpdate()
    {
      if(isJumping == false && moveHorizontal > 0.1f || moveHorizontal < -0.1f){
        rb.AddForce(new Vector2(moveHorizontal * movementSpeed, 0f), ForceMode2D.Impulse);
      }

      if(!isJumping && moveHorizontal > 0.1f || moveHorizontal < -0.1f){
        rb.velocity = new Vector2(moveHorizontal, 0) * movementSpeed;
      }

      if(!isJumping && moveVertical > 0.1f){
        rb.AddForce(new Vector2(0f, moveVertical * jumpHeight), ForceMode2D.Impulse);
      }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.gameObject.tag == "Ground"){
        isJumping = false;
      }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
      if(collision.gameObject.tag == "Ground"){
        isJumping = true;
      }
    }

    /*
      public float movementSpeed = 5f;
  public float jumpHeight = 15f;
  Rigidbody2D rb;

  private void Awake()
  {
    rb = GetComponent<Rigidbody2D>();
  }

  private void Update()
  {
    float xMov = Input.GetAxisRaw("Horizontal");
    bool jump = Input.GetKeyDown(KeyCode.Space);
    if(jump){
      rb.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
    }
    rb.velocity = new Vector2(xMov, 0).normalized * movementSpeed;
  }
    */
}
