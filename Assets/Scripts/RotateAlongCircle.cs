using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAlongCircle : MonoBehaviour
{
    float angle = 0;
    public float secondsPerCircle = 5; //2*PI in degress is 360, so you get 5 seconds to complete a circle
    float speed;
    public float radius;
    Transform init;
    float previous_x;
    float previous_y;

    void Start()
	{
        init = transform;
        print("INIT" + init.position);
        speed = (2 * Mathf.PI) / secondsPerCircle;
        previous_x = 0;
        previous_y = 0;
    }

    void Update()
    {
        angle += speed * Time.deltaTime; //if you want to switch direction, use -= instead of +=
        float x = Mathf.Cos(angle) * radius;

        float y = Mathf.Sin(angle) * radius;

        transform.position = new Vector3(init.position.x + x-previous_x, init.position.y, init.position.z - (y - previous_y));
     

        previous_x = x;
        previous_y = y;
    }
    
      
}
