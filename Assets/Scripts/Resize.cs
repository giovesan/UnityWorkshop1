using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resize : MonoBehaviour
{

    public Vector3 resizeRand;
    Vector3 randomSize;
    public int smoothingFrames;
    int counter = 0;
    Vector3 storeNewScale;
    // Start is called before the first frame update
    void Start()
    {
        storeNewScale = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
 
        if (counter == 0)
        {
            randomSize = new Vector3(Random.Range(-resizeRand.x, resizeRand.x) / smoothingFrames, Random.Range(-resizeRand.y, resizeRand.y) / smoothingFrames,
                Random.Range(-resizeRand.z, resizeRand.z) / smoothingFrames);
        }

        transform.localScale = new Vector3(storeNewScale.x + randomSize.x * counter, storeNewScale.y + randomSize.y * counter, storeNewScale.z + randomSize.z * counter);

        if (counter < smoothingFrames)
        {
            counter += 1;
        }
        else { counter = 0; storeNewScale = transform.localScale; }
    }
}
