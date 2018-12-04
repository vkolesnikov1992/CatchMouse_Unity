using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringImpulse : MonoBehaviour {

    [SerializeField] private float JumpForse;
    private float JumpDirections = 5;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "mouse")
        {
            MouseController.IsMovingMouse = false;
            if (MouseController.isRightMove)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(JumpDirections, JumpForse), ForceMode2D.Impulse);
            }
            else
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-JumpDirections, JumpForse), ForceMode2D.Impulse);
            }

            Invoke("ActivationVelocityMouse", 0.4f);
        }
    }

    bool ActivationVelocityMouse()
    {
        return MouseController.IsMovingMouse = true;
    }
    
   
}
