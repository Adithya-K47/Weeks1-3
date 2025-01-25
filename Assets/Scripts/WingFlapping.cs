using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingFlapping : MonoBehaviour
{
    float wingup = -76f;
    float wingdown = -110f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // Rotate the wing up
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, wingdown);
        }
        else
        {
            // Rotate the wing down
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, wingup);
        }




    }

    

    
}