using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{

    private float mouseSpeed = 3.0f;    
    private Rigidbody2D rb;
    private bool coll;
    public static bool isRightMove = true;
    public static bool IsMovingMouse = true;
  

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (IsMovingMouse)
        {
            if (isRightMove)
            {
                // transform.Translate(mouseSpeed * Time.deltaTime * speedX, 0, 0);

                rb.velocity = new Vector2(mouseSpeed, 0);

            }
            else if (!isRightMove)
            {
                // transform.Translate(mouseSpeed * Time.deltaTime * speedX, 0, 0);
                rb.velocity = new Vector2(-mouseSpeed, 0);

            }

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Wall" && !coll)
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
         else if(collision.gameObject.name == "SmallWall(Clone)")
          {
            
              transform.Translate(0f, 0.5f, 0);

             
          }
        
          if(collision.gameObject.name == "Wall" && coll)
          {
            transform.Translate(0, 0.6f, 0);
            
          }        
       
              
        
      }

    private bool OnCollisionEnter2D(Collision collision)
    {
        if (collision.gameObject.name == "SmallWall(Clone)" || collision.gameObject.name == "Air")
        {
            coll = true;
        }
        else coll = false;
        return coll;

        
    }

   






}