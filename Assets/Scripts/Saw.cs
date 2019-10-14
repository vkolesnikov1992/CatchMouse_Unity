using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour

{
    private int x = 0;
    [SerializeField]
    
    private void FixedUpdate()
    {
        GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, x++);
       
    }

    

    
}
