using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallWall : MonoBehaviour
{
    [SerializeField] private float JumpForse;
    [SerializeField] private float JumpDirections;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "mouse")
        {
            //  MouseController.IsMovingMouse = false;
            if (MouseController.isRightMove)
            {

                // collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-JumpDirections, JumpForse), ForceMode2D.Impulse);

                Debug.Log("done");
            }
            else
            {
                // collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-JumpDirections, JumpForse), ForceMode2D.Impulse);
            }


        }
    }
}
