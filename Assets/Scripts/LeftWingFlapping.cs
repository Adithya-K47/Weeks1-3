using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWingFlapping : MonoBehaviour
{
    //declaring variables for wing positions
    float wingdown = -80f;
    float wingup = -100f;

    // Update is called once per frame
    void Update()
    {
        //tell game to update the wing object's rotation
        if (Input.GetKey(KeyCode.Space))
        {
            //rotate wing down when holding down space
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, wingdown);
        }
        else
        {
            //rotate wing up when not holding down space
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, wingup);
        }
    }
    
}
