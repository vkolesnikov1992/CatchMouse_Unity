﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControllerY : MonoBehaviour {

    public float speed;

    private Vector2 startPos;
    private Camera cam;

    private float targetPos;

    public GameObject panel;

    // Use this for initialization
    void Start()
    {
        cam = GetComponent<Camera>();
        targetPos = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        if (!DragDrop.mouseDown)
        {
            if (!CreateSmallWall.mouseDown)
            {
                if (Input.GetMouseButtonDown(0)) startPos = cam.ScreenToWorldPoint(Input.mousePosition);
                else if (Input.GetMouseButton(0))
                {
                    float pos = cam.ScreenToWorldPoint(Input.mousePosition).y - startPos.y;
                    targetPos = Mathf.Clamp(transform.position.y - pos, -2f, 32f);
                }
                transform.position = new Vector3(transform.position.x, Mathf.Lerp(transform.position.y, targetPos, speed * Time.deltaTime), transform.position.z);

                panel.transform.position = new Vector3(panel.transform.position.x, transform.position.y, panel.transform.position.z);
            }
        }
    }
}