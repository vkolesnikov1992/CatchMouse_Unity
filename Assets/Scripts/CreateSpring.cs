
using UnityEngine;

public class CreateSpring : MonoBehaviour {

    public GameObject Spring;
    private GameObject newSpring;
    public static bool mouseDown;


    void OnMouseDown()
    {
        newSpring = Instantiate(Spring, transform.position, transform.rotation);
        mouseDown = true;

    }

    void OnMouseDrag()
    {
        Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
        newSpring.transform.position = Camera.main.ScreenToWorldPoint(newPosition);


    }
    private void OnMouseUp()
    {
        mouseDown = false;

    }
}
