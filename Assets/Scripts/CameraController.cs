using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public float speed;

    private Vector2 startPos;
    private Camera cam;

    private float targetPos;

    public GameObject panel;

    [SerializeField]
    private float xPosRight;
    [SerializeField]
    private float xPosLeft;

    Vector3 touchStart;
    public float zoomOutMin = 1;
    public float zoomOutMax = 8;






    // Use this for initialization
    void Start () {
        cam = GetComponent<Camera>();
        targetPos = transform.position.x;

        
         
		
	}

    // Update is called once per frame
    void Update()
    {
        if (!DragDrop.mouseDown)
        {
            if (!CreateSmallWall.mouseDown)
            {
                if (!CreateFan.mouseDown)
                {
                    if (!CreateSpring.mouseDown)

                    {
                        if (Input.GetMouseButtonDown(0)) startPos = cam.ScreenToWorldPoint(Input.mousePosition);
                        else if (Input.GetMouseButton(0))
                        {
                            float pos = cam.ScreenToWorldPoint(Input.mousePosition).x - startPos.x;
                            targetPos = Mathf.Clamp(transform.position.x - pos, xPosLeft, xPosRight);
                        }
                        transform.position = new Vector3(Mathf.Lerp(transform.position.x, targetPos, speed * Time.deltaTime), transform.position.y, transform.position.z);

                        if (!MovePanel.panelOpen)
                        {
                            panel.transform.position = new Vector3(transform.position.x + 12.25f, panel.transform.position.y, panel.transform.position.z);
                        }
                        if (MovePanel.panelOpen)
                        {
                            panel.transform.position = new Vector3(transform.position.x + 6.9f, panel.transform.position.y, panel.transform.position.z);
                        }                     



                    }
                }
            }
        }
        
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            float difference = currentMagnitude - prevMagnitude;

            zoom(difference * 0.01f);
        }
        
        zoom(Input.GetAxis("Mouse ScrollWheel"));

    }
    void zoom(float increment)
    {
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - increment, zoomOutMin, zoomOutMax);
    }
}
