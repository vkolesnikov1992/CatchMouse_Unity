using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray : MonoBehaviour
{

    public float rayDistance;
    private Ray2D ray;
    private RaycastHit raycast;
    [SerializeField]
    private float ForceFun, DirectionFun;
    Vector2 newPosR, newPosL;
    
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        newPosR = new Vector2(transform.position.x + 100f, transform.position.y + 100f);
        newPosL = new Vector2(transform.position.x - 100f, transform.position.y + 100f);
    }

    //Update is called once per frame
    void FixedUpdate()
    {
        
        ray = new Ray2D(new Vector2(transform.position.x, transform.position.y), -Vector2.up);
        Debug.DrawRay(new Vector2(transform.position.x, transform.position.y - 0.62f), ray.direction * 7);
        
        
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y - 0.62f), -Vector2.up, rayDistance);
        if (hit.collider != null)
        {

            if (hit.collider.tag == "Fan" && MouseController.isRightMove)
            {              
              
                rb.AddForce(Vector2.up * ForceFun, ForceMode2D.Force);
                
            }
            
            else if (hit.collider.tag == "Fan" && !MouseController.isRightMove)
            {
                rb.AddForce(Vector2.up * ForceFun, ForceMode2D.Force);

            }

        }

        RaycastHit2D hitSmallWallRight = Physics2D.Raycast(new Vector2(transform.position.x + 0.4f, transform.position.y - 0.45f), Vector2.right, 0.3f);     
        RaycastHit2D hitSmallWallLeft = Physics2D.Raycast(new Vector2(transform.position.x - 0.4f, transform.position.y - 0.45f), -Vector2.right, 0.3f);
        RaycastHit2D hitSmallWallDown = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y - 0.6f), -Vector2.up, 3f);

        if(hitSmallWallRight.collider != null)
        {
           if (hitSmallWallRight.collider.name == "SmallWall(Clone)" && MouseController.isRightMove)
            {               
               transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), newPosR, 5f * Time.deltaTime);
                
            }
           
            if (hitSmallWallRight.collider.tag == "Ground" && MouseController.isRightMove)
            {
                transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), newPosR, 1f * Time.deltaTime);
                
            }
            
        }

       
        if (hitSmallWallLeft.collider != null)
        {
            if (hitSmallWallLeft.collider.name == "SmallWall(Clone)" && !MouseController.isRightMove)
            {
                transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), newPosL, 5f * Time.deltaTime);
            }
           
            if (hitSmallWallLeft.collider.tag == "Ground" && !MouseController.isRightMove)
            {
                transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), newPosL, 1f * Time.deltaTime);
            }
           
        }


        if (hitSmallWallDown.collider != null && hitSmallWallRight.collider != null || hitSmallWallDown.collider != null && hitSmallWallLeft.collider != null)
        {
            if (hitSmallWallDown.collider.name == "SmallWall(Clone)" && hitSmallWallRight.collider != null && MouseController.isRightMove)
            {
                transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), newPosR, 5f * Time.deltaTime);

            }

            if (hitSmallWallDown.collider.name == "SmallWall(Clone)" && hitSmallWallLeft.collider != null && !MouseController.isRightMove)
            {
                transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), newPosL, 5f * Time.deltaTime);

            }       
         

        }
       
    }
    
}
