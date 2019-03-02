using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringImpulse : MonoBehaviour {

    [SerializeField] private float JumpForse;
    [SerializeField] private float JumpDirections;
    private SpriteRenderer spriteRenderer;
    [SerializeField] Sprite sprite, sprite2;


    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "mouse")

        {
            spriteRenderer.sprite = sprite2;
            
            if (MouseController.isRightMove)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(JumpDirections, JumpForse), ForceMode2D.Force);




            }
            else
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-JumpDirections, JumpForse), ForceMode2D.Force);
            }


        } 


    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "mouse")
        {
            Invoke("invokeSprite",0.3f);
        }
    }

    void invokeSprite()
    {
        spriteRenderer.sprite = sprite;
    }




}