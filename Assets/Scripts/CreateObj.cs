using UnityEngine;
using UnityEngine.UI;

public class CreateObj : MonoBehaviour
{
    public GameObject obj;
    private GameObject newObj;
    [SerializeField]
    private int count;
    private Text TextCount;





    private void Start()
    {
        TextCount = GetComponentInChildren<Text>();
        TextCount.text = count.ToString();


    }



    void OnMouseDown()
    {
        GameController.MouseDown = true;

        if (count > 0)
        {
            newObj = Instantiate(obj, transform.position, transform.rotation);            
            count--;
            TextCount.text = count.ToString();

        }



        if (count == 0)
        {
            GetComponent<Collider2D>().enabled = false;
        }

    }

    private void OnMouseUp()
    {
        GameController.MouseDown = false;
    }

    void OnMouseDrag()
    {

        Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
        newObj.transform.position = Camera.main.ScreenToWorldPoint(newPosition);




    }
}
