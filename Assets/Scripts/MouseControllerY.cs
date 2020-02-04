using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControllerY : MonoBehaviour {

    public float speed;

    private Vector2 startPos;
    private Camera cam;

    private float targetPos;

   // public GameObject panel;

    [SerializeField]
    private float yPosDown;
    [SerializeField]
    private float yPosUp;

    // Use this for initialization
    void Start()
    {
        cam = GetComponent<Camera>();
        targetPos = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        if (!StartGame.GameStarted)
        {

            
                    if (!GameController.MouseDown)
                    {
                       
                                if (Input.GetMouseButtonDown(0)) startPos = cam.ScreenToWorldPoint(Input.mousePosition);
                                else if (Input.GetMouseButton(0))
                                {
                                    float pos = cam.ScreenToWorldPoint(Input.mousePosition).y - startPos.y;
                                    targetPos = Mathf.Clamp(transform.position.y - pos, yPosDown, yPosUp);
                                }
                                transform.position = new Vector3(transform.position.x, Mathf.Lerp(transform.position.y, targetPos, speed * Time.deltaTime), transform.position.z);


                    }
               
            
        }
    }
}