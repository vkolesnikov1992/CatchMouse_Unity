using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray : MonoBehaviour
{

    public float rayDistance;
    // private Ray2D ray;
    private RaycastHit raycast;
    [SerializeField]
    private float ForceFun;
    
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        ray = new Ray2D(new Vector2(transform.position.x, transform.position.y), -transform.up);
        Debug.DrawRay(new Vector2(transform.position.x, transform.position.y - 0.6f), ray.direction * rayDistance);
        */
        
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y - 0.6f), -Vector2.up, rayDistance);
        if (hit.collider != null)
        {
            if (hit.collider.name == "Fan(Clone)")
            {

                
                
                rb.AddForce(new Vector2(0, ForceFun), ForceMode2D.Force);
            }                  

        }
    }
    
}
