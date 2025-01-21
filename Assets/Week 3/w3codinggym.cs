using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Rendering;

public class w3codinggym : MonoBehaviour
{
    float speed;
    float rSpeed;
    public AnimationCurve jump;
    public AnimationCurve flip;
    public float t;
    bool timer = false;
    bool jumping = false;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.01f;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed;
        Vector3 rot = transform.eulerAngles;
        rot.z = rSpeed;
        if (Input.GetKeyDown(KeyCode.Space) && jumping == false)
        {
            timer = true;

        }
        if (timer == true)
        {
            t += Time.deltaTime;
            pos.y = jump.Evaluate(t);
            rot.z = flip.Evaluate(t);

            if (t > 1)
            {
                timer = false;
                t = 0;
            }
        }

        

        
      

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x < 0 || screenPos.x> Screen.width)
        {
            speed *= -1;
        }
        transform.position = pos;
        transform.eulerAngles = rot;
    }
}
