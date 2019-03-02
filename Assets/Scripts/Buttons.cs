using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

    private void OnMouseDown()
    {
        transform.localScale = new Vector3(transform.localScale.x + 0.2f, transform.localScale.y + 0.2f, transform.localScale.y); 
    }

    private void OnMouseUp()
    {
        transform.localScale = new Vector3(transform.localScale.x - 0.2f, transform.localScale.y - 0.2f, transform.localScale.y);
    }

    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "play":
                Application.LoadLevel("Level1");                
                break;

            case "likeGame":
                Application.OpenURL("");
                break;

            case "fb":
                Application.OpenURL("");
                break;
        }
    }
}
