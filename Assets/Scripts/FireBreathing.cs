using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBreathing : MonoBehaviour
{
    //variable to change the firebreathing speed
    public float speed = 0.5f; 

    //maximum and minimum size of the fire
    Vector3 fullScale = new Vector3(1f, 1f, 1f);
    Vector3 OGScale = new Vector3(0.001f, 0.001f, 0.001f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //what happens when you press Q
        if (Input.GetKey(KeyCode.Q))
        {
           //variable to store the scale of object
            Vector3 scaleNow = transform.localScale;

            //scaling up the fire if fire isnt at max value yet)
            if (scaleNow.x < fullScale.x)
            {
                scaleNow.x += speed * Time.deltaTime;
                if (scaleNow.x > fullScale.x)
                    scaleNow.x = fullScale.x;
            }
            //stopping the scaling if fire is at max value
            if (scaleNow.y < fullScale.y)
            {
                scaleNow.y += speed * Time.deltaTime;
                if (scaleNow.y > fullScale.y)
                    scaleNow.y = fullScale.y;
            }
            //telling game that current scale of the object is the variable declared earlier
            transform.localScale = scaleNow;
        }

        if (Input.GetKey(KeyCode.E))
        {
            //redeclaring it just to be safe
            Vector3 scaleNow = transform.localScale;

            //scaling down fire if it isnt at min value yet
            if (scaleNow.x > OGScale.x)
            {
                scaleNow.x -= speed * Time.deltaTime;
                if (scaleNow.x < OGScale.x)
                    scaleNow.x = OGScale.x;
            }

            //stopping the scaling if fire is at min value
            if (scaleNow.y > OGScale.y)
            {
                scaleNow.y -= speed * Time.deltaTime;
                if (scaleNow.y < OGScale.y)
                    scaleNow.y = OGScale.y;
            }
            //telling game that current scale of the object is the variable declared earlier
            transform.localScale = scaleNow;
        }


    }
}
