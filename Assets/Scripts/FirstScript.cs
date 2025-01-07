using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += -speed;

        Vector2 screenSize = new Vector2(Screen.width, Screen.height);
        Vector2 screenSizeITW = new Vector2();
        screenSizeITW = Camera.main.ScreenToWorldPoint(screenSize);

        Vector2 screenZeroITW = Camera.main.ScreenToWorldPoint(Vector2.zero);

        if (pos.x < screenZeroITW.x || pos.x > screenSizeITW.x)
        {
            speed = speed * -1;
        }
        transform.position = pos;
    }
}
