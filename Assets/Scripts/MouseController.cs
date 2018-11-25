using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{

    public float mouseSpeed = 5.0f;
    float speedX = 1.0f;
    private Rigidbody2D rb;
    private bool coll;
    private bool collAir;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (speedX > 0)
        {
             transform.Translate(mouseSpeed * Time.deltaTime * speedX, 0, 0);
            // rb.AddForce(new Vector2(5, 0),ForceMode2D.Force);
        }
        else if (speedX < 0)
        {
            transform.Translate(mouseSpeed * Time.deltaTime * speedX, 0, 0);
        }



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Wall" && !coll)
        {
            if (speedX > 0)
            {
                // speedX = -1;
                transform.Rotate(0, 180, 0);
            }

            else if (speedX < 0)
            {
                speedX = 1;
                transform.Rotate(0, 0, 0);
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
          
          if(collision.gameObject.name == "Spring(Clone)")
        {
            rb.AddForce(new Vector2(0,10), ForceMode2D.Impulse);
           
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