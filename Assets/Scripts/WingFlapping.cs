using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingFlapping : MonoBehaviour
{
    //declaring variables for wing positions
    float wingup = -76f;
    float wingdown = -110f;

    void Start()
    {
        //transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, wingup);

    }
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