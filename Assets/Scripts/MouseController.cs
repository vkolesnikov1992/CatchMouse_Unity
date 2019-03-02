using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{

    private float mouseSpeed = 3.0f;    
    private Rigidbody2D rb;   
   // private bool coll;
    public static bool isRightMove = true;
    public static bool IsMovingMouse;

    
  

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (IsMovingMouse)
        {
                if (isRightMove)
                {
                    rb.velocity = new Vector2(mouseSpeed, 0);

                }
                else if (!isRightMove)
                {

                    rb.velocity = new Vector2(-mouseSpeed, 0);
                }

        }
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "walls")
        {
            if (isRightMove)
            {
                isRightMove = false;
                transform.Rotate(0, 180, 0);
            }

            else if (!isRightMove)
            {
                isRightMove = true;
                transform.Rotate(0, 180, 0);
            }
           
        }
        
       
    }
    
    private void OnCollisionStay2D(Collision2D collision)
    {
        //IsMovingMouse = true;
        if (collision.gameObject.tag == "Ground")
        {
            IsMovingMouse = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
            IsMovingMouse = false;
        
    }
    
}