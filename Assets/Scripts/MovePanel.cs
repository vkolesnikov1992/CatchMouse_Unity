
using UnityEngine;

public class MovePanel : MonoBehaviour {
    public static bool panelOpen;    
    public float speed = 6f;
    private float distance = 5.35f;

	// Use this for initialization
	void Start () {
        panelOpen = false;
        
	}
	
	
    private void OnMouseDown()
    {
        if (panelOpen)
        {
            transform.position = new Vector3(transform.position.x + distance, transform.position.y, transform.position.z);
            panelOpen = false;
        }
        else if (!panelOpen)
        {
            panelOpen = true;
            transform.position = new Vector3(transform.position.x - distance, transform.position.y, transform.position.z);
        }
    }
}
