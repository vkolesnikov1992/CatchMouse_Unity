using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{

    private GameObject coin0;
    private GameObject coin1;
    private GameObject coin2;
    public static int counter;
    
    
   

    private void Start()
    {
        coin0 = GameObject.Find("Coin0");
        coin1 = GameObject.Find("Coin1");
        coin2 = GameObject.Find("Coin2");
        counter = 0;
        
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
       if(other.tag == "mouse")
        {
            
                  
            
            Destroy(gameObject);
            
            
            counter++;

            
            
            switch (counter)
            {
                case 1:
                    coin0.GetComponent<Image>().enabled = true;                    
                    break;

                case 2:
                    coin1.GetComponent<Image>().enabled = true;                    
                    break;

                case 3:
                    coin2.GetComponent<Image>().enabled = true;                    
                    break;
            }
           
            
        }
    }

}
