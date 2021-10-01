using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float responsiveness;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey(KeyCode.Q)){
            transform.Rotate(new Vector3(0, -1, 0) * responsiveness * Time.deltaTime);
		}
        if (Input.GetKey(KeyCode.E)){
            transform.Rotate(new Vector3(0, 1, 0) * responsiveness * Time.deltaTime);
        }
    }
}
