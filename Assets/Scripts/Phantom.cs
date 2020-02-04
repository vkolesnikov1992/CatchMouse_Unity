using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phantom : MonoBehaviour {

    
    private GameObject phantom;
    private SpriteRenderer sprite;
    private Transform position;
    private bool mouseDown;  
    RaycastHit2D hit;



    // Use this for initialization
    void Start () {
        phantom = GameObject.FindGameObjectWithTag("Phantom" + gameObject.name);
        sprite = phantom.GetComponent<SpriteRenderer>();
        position = phantom.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        
       
        if (GameController.MouseDown && mouseDown) 
        {
            hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y - 0.80f), -Vector2.up, 20);            
            if (hit.collider != null && hit.collider.tag == "Ground")
            {
                
                position.position = new Vector2(hit.point.x, hit.point.y + transform.localScale.y);

                
                sprite.enabled = true;
            }
            
            
        }
        else
        {
            sprite.enabled = false;
        } 
        
        
        
        
   
    }
    private void OnMouseDown()
    {
        GameController.MouseDown = true;
        sprite.enabled = true;
        mouseDown = true;
    }

   

    private void OnMouseUp()
    {
        GameController.MouseDown = false;
        sprite.enabled = false;
        mouseDown = false;
    }

}
