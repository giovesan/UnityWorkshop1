using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndRotate : MonoBehaviour
{
    public Vector3 rot;
    public Vector3 trasl;
    Vector3 randomTrasl;
    public int smoothingFrames;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rot.x, rot.y, rot.z);
        //  transform.position = new Vector3(transform.position.x + Random.Range(-trasl.x, trasl.x), transform.position.y + Random.Range(-trasl.y, trasl.y),
        // transform.position.z + Random.Range(-trasl.z, trasl.z));

        if (counter == 0)
        {
            randomTrasl = new Vector3(Random.Range(-trasl.x, trasl.x) , Random.Range(-trasl.y, trasl.y) ,
                Random.Range(-trasl.z, trasl.z) );
        }

        transform.position = new Vector3(transform.position.x + randomTrasl.x/smoothingFrames, transform.position.y + randomTrasl.y/smoothingFrames, transform.position.z +
            randomTrasl.z /smoothingFrames);

       

        if (counter < smoothingFrames)
        {
            counter += 1;
        }
        else { counter = 0; }

		
    }
}
