using UnityEngine;

public class Portal : MonoBehaviour {

    private Transform Destination;

    [SerializeField]
    private bool isOrange;
    [SerializeField]
    private float Distance;

    private void Start()
    {
        if (!isOrange)
        {
            Destination = GameObject.FindGameObjectWithTag("OrangePortal").GetComponent<Transform>();
        }
        else
        {
            Destination = GameObject.FindGameObjectWithTag("BluePortal").GetComponent<Transform>();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(Vector2.Distance(transform.position, other.transform.position) > Distance && other.gameObject.name == "mouse")
        {
            
            other.transform.position = new Vector2(Destination.position.x, Destination.position.y);
        }
            
    }

}
