using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SNM : MonoBehaviour
{
    public float snm = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        rot.z += snm;
        transform.eulerAngles = rot;

    }
}
