using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public float speed;

    private Vector2 startPos;
    private Camera cam;

    private float targetPos;

    public GameObject panel;

    
    



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
                                    targetPos = Mathf.Clamp(transform.position.x - pos, -2f, 32f);
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
    }
}
