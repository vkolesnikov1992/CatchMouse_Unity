using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlManager : MonoBehaviour
{
    
    
    
    // Start is called before the first frame update
    void Start()
    {
       // PlayerPrefs.SetInt("LevelCounter", 0);
       // PlayerPrefs.SetInt("Level" + 0 + "Score", 0);
       // PlayerPrefs.SetInt("Level" + 1 + "Score", 0);


        for (int i = 0; i < transform.childCount; i++)
        {
            if(i  <= PlayerPrefs.GetInt("LevelCounter"))
            {
                
                transform.GetChild(i).GetComponent<Button>().interactable = true;
                if(PlayerPrefs.GetInt("Level" + i + "Score") != 0) 
                {
                    
                   
                    for (int j = 0; j < transform.GetChild(i).childCount; j++)
                    {
                       
                        if (PlayerPrefs.GetInt("Level" + i + "Score") >= j)
                        {
                            
                            transform.GetChild(i).transform.GetChild(j).GetComponent<SpriteRenderer>().enabled = true;
                        
                        }
                    }
                }
            }
            else
            {
                transform.GetChild(i).GetComponent<Button>().interactable = false;
            }
        }
    }

   
}
