using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBreathing : MonoBehaviour
{
    public float speed = 0.5f; 

    Vector3 fullScale = new Vector3(1f, 1f, 1f);
    Vector3 OGScale = new Vector3(0.001f, 0.001f, 0.001f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Vector3 scaleNow = transform.localScale;

            if (scaleNow.x < fullScale.x)
            {
                scaleNow.x += speed * Time.deltaTime;
                if (scaleNow.x > fullScale.x)
                    scaleNow.x = fullScale.x;
            }

            if (scaleNow.y < fullScale.y)
            {
                scaleNow.y += speed * Time.deltaTime;
                if (scaleNow.y > fullScale.y)
                    scaleNow.y = fullScale.y;
            }

            transform.localScale = scaleNow;
        }

        if (Input.GetKey(KeyCode.E))
        {
            Vector3 scaleNow = transform.localScale;

            if (scaleNow.x > OGScale.x)
            {
                scaleNow.x -= speed * Time.deltaTime;
                if (scaleNow.x < OGScale.x)
                    scaleNow.x = OGScale.x;
            }

            if (scaleNow.y > OGScale.y)
            {
                scaleNow.y -= speed * Time.deltaTime;
                if (scaleNow.y < OGScale.y)
                    scaleNow.y = OGScale.y;
            }

            transform.localScale = scaleNow;
        }


    }
}
