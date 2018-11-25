
using UnityEngine;

public class CreateFan : MonoBehaviour {
    public GameObject Fun;
    private GameObject newFun;
    public static bool mouseDown;


    void OnMouseDown()
    {
        newFun = Instantiate(Fun, transform.position, transform.rotation);
        mouseDown = true;

    }

    void OnMouseDrag()
    {
        Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
        newFun.transform.position = Camera.main.ScreenToWorldPoint(newPosition);


    }
    private void OnMouseUp()
    {
        mouseDown = false;

    }
}
