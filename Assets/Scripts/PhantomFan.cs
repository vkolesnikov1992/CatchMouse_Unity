using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhantomFan : MonoBehaviour
{
    private GameObject phantom;
    private SpriteRenderer sprite;
    private Transform position;
    private bool isActive;
    RaycastHit2D hit;



    // Use this for initialization
    void Start()
    {
        phantom = GameObject.FindGameObjectWithTag("PhantomFan");
        sprite = phantom.GetComponent<SpriteRenderer>();
        position = phantom.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {


        if (isActive)
        {
            hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y - 0.80f), -Vector2.up, 20);
            if (hit.collider != null && hit.collider.tag == "Ground")
            {

                position.position = new Vector2(hit.point.x, hit.point.y + transform.localScale.y - 0.6f);


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
