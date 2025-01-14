using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HourHandRotation : MonoBehaviour
{
    public float hourHand = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        rot.z += hourHand;
        transform.eulerAngles = rot;

    }
}
