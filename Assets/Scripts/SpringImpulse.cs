using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringImpulse : MonoBehaviour {

    [SerializeField] private float JumpForse;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "mouse")
        {

            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, JumpForse), ForceMode2D.Impulse);         
           Debug.Log(collision.gameObject.GetComponent<Rigidbody2D>());
        }
    }
    
   
}
