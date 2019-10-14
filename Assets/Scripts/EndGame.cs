using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{

    private GameObject endLevel;
    private GameObject restart;
    private GameObject nextLevel;    
    private GameObject stars;
    [SerializeField]
    private int LvlNumber;

    // Start is called before the first frame update
    void Start()
    {
        endLevel = GameObject.FindGameObjectWithTag("EndLevel");
        restart = GameObject.Find("restart");
        nextLevel = GameObject.Find("next lvl");       
        stars = GameObject.Find("Stars");
        nextLevel.GetComponent<CircleCollider2D>().enabled = false;

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "mouse")
        {
            MouseController.IsMovingMouse = false;
            endLevel.GetComponent<Image>().enabled = true;
            restart.GetComponent<Image>().enabled = true;
            nextLevel.GetComponent<Image>().enabled = true;
            nextLevel.GetComponent<CircleCollider2D>().enabled = true;
            GetComponent<AudioSource>().Play();

            for(int i = 0; i < Coin.counter; i++)
            {
                stars.transform.GetChild(i).GetComponent<SpriteRenderer>().enabled = true;
            }

            PlayerPrefs.SetInt("Level"+ LvlNumber +"Score", Coin.counter);
            if(LvlNumber == PlayerPrefs.GetInt("LevelCounter"))
            {
                PlayerPrefs.SetInt("LevelCounter", PlayerPrefs.GetInt("LevelCounter") + 1);
            }
        }
    }
}
