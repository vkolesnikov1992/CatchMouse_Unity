
using UnityEngine;

public class CreateSmallWall : MonoBehaviour {

    public GameObject smallWall;    
    private GameObject newSmallWall;
    public static bool mouseDown;
       

    void OnMouseDown()
    {
        newSmallWall = Instantiate(smallWall, transform.position, transform.rotation);
        mouseDown = true;
        
    }

    void OnMouseDrag()
    {
        Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
        newSmallWall.transform.position = Camera.main.ScreenToWorldPoint(newPosition);


    }
    private void OnMouseUp()
    {
        mouseDown = false;

    }

}
