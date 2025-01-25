using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWingFlapping : MonoBehaviour
{
    float wingdown = -80f;
    float wingup = -100f;

    // Update is called once per frame
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
