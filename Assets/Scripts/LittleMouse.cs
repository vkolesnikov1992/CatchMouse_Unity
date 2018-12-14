using UnityEngine;

public class LittleMouse : MonoBehaviour {
    [SerializeField] private float Time;
    private Vector3 ScaleLittleMouse;
    private Vector3 ScaleNormalMouse;
	// Use this for initialization
	
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ScaleLittleMouse = new Vector3(0.1f, 0.1f, 0.3f);
        if (collision.gameObject.name == "mouse")
        {
            collision.gameObject.GetComponent<Transform>().localScale = ScaleLittleMouse;
        }
        Invoke("NormalScale", Time);
    }

    private void NormalScale()
    {
        ScaleNormalMouse = new Vector3(0.3f, 0.3f, 0.3f);
        GameObject.FindGameObjectWithTag("Mouse").GetComponent<Transform>().localScale = ScaleNormalMouse;
    }

}
