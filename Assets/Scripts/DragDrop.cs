using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour {

    public static bool GameStarted;
    

    private Vector3 offset;

    void OnMouseDown()
    {
        if (!GameStarted)
        {
            offset = gameObject.transform.position -
            Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
            GameController.MouseDown = true;
        }
        
    }
    
    void OnMouseDrag()
    {
        if (!GameStarted)
        {
            Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
            transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
        }
        
    }

    


    private void OnMouseUp()
    {
        if (!GameStarted)
        {
            GameController.MouseDown = false;
        }
        

    }
}



