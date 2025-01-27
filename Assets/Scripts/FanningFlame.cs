using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class FanningFlame : MonoBehaviour
{
 
    public AnimationCurve Fan;
    //float to control the fan flickering
    public float t;
    //Vectors to declare the minimum and maximum value
    public Vector3 minScale = Vector3.one;
    public Vector3 maxScale = Vector3.one; 

    // Start is called before the first frame update
    void Start()
    {
        //telling the game to start with the min value
        transform.localScale = minScale;
        t = 0;

    }

    // Update is called once per frame
    void Update()
    {
        //t will scale back and forth from 0 and 1
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }
        //telling the game that scale will interpolate between the min and max scale and factor it with animation curve
        transform.localScale = Vector3.Lerp(minScale, maxScale, Fan.Evaluate(t));
        //Debug.Log("scale"+transform.localScale);

    }
}
