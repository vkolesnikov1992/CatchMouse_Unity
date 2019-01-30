using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleMouse : MonoBehaviour {

    [SerializeField] private float Time;
    private Vector3 ScaleLittleMouse;
    private Vector3 ScaleNormalMouse;
    // Use this for initialization


    private void OnCollisionEnter2D(Collision2D collision)
    {
        ScaleLittleMouse = new Vector3(0.4f, 0.4f, 1);
        if (collision.gameObject.name == "mouse")
        {
            collision.gameObject.GetComponent<Transform>().localScale = ScaleLittleMouse;
        }
        Invoke("NormalScale", Time);
    }

    private void NormalScale()
    {
        ScaleNormalMouse = new Vector3(0.7f, 0.7f, 1);
        GameObject.FindGameObjectWithTag("mouse").GetComponent<Transform>().localScale = ScaleNormalMouse;
    }
}
