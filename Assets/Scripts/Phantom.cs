using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phantom : MonoBehaviour {

    private Ray2D ray;
    private GameObject phantom;
    private SpriteRenderer sprite;
    private Transform position;
    public static bool isActive;
    
   

	// Use this for initialization
	void Start () {
        phantom = GameObject.FindGameObjectWithTag("PhantomSmallWall");
        sprite = phantom.GetComponent<SpriteRenderer>();
        position = phantom.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        ray = new Ray2D(new Vector2(transform.position.x, transform.position.y), -Vector2.up);
        Debug.DrawRay(new Vector2(transform.position.x, transform.position.y - 0.80f), ray.direction * 20);

        if (isActive) 
        {
            RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y - 0.80f), -Vector2.up, 20);            
            if (hit.collider != null && hit.collider.tag == "Ground")
            {
                
                position.position = new Vector2(hit.point.x, hit.point.y + transform.localScale.y * 3);
                Debug.Log(hit.point);



            }
        }
        
        
        
   
    }
    private void OnMouseDown()
    {
        isActive = true;
        sprite.enabled = true;
    }

    private void OnMouseUp()
    {
        isActive = false;
        sprite.enabled = false;
    }

}
