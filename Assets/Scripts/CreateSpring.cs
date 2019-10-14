
using UnityEngine;
using UnityEngine.UI;

public class CreateSpring : MonoBehaviour {

    public GameObject Spring;
    private GameObject newSpring;
    public static bool mouseDown;
    [SerializeField]
    private int count;
    private Text TextCount;


    private GameObject phantom;
    private SpriteRenderer sprite;
    private Transform position;
    private bool isActive;
    RaycastHit2D hit;


    private void Start()
    {
        TextCount = GetComponentInChildren<Text>();
        TextCount.text = count.ToString();

        phantom = GameObject.FindGameObjectWithTag("PhantomSpring");
        sprite = phantom.GetComponent<SpriteRenderer>();
        position = phantom.GetComponent<Transform>();
    }

    private void Update()
    {
        if (isActive)
        {
            hit = Physics2D.Raycast(new Vector2(newSpring.transform.position.x, newSpring.transform.position.y - 0.80f), -Vector2.up, 20);
            if (hit.collider != null && hit.collider.tag == "Ground")
            {

                position.position = new Vector2(hit.point.x, hit.point.y + transform.localScale.y - 0.3f);


            }
        }
    }

    void OnMouseDown()
    {
        if (count > 0)
        {
            newSpring = Instantiate(Spring, transform.position, transform.rotation);
            mouseDown = true;

            count--;
            TextCount.text = count.ToString();
        }

        if (count == 0)
        {
            GetComponent<Collider2D>().enabled = false;
        }

        isActive = true;
            sprite.enabled = true;

     }
    
    void OnMouseDrag()
    {
        Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
        newSpring.transform.position = Camera.main.ScreenToWorldPoint(newPosition);


    }
    

    private void OnMouseUp()
    {
        mouseDown = false;

            isActive = false;
            sprite.enabled = false;

    }
}
