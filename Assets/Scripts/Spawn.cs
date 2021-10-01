using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public int numOfCubes;
    public int numOfSpheres;
    public GameObject CubePrefab;
    public GameObject SpherePrefab;
    public Vector3 Area;
    // Start is called before the first frame update
    void Start()
    {
        
        for(int i = 0; i < numOfCubes; i++)
		{
            GameObject nthCube = Instantiate(CubePrefab);
            float x = Random.Range(-Area.x, Area.x);
            float y = Random.Range(0, Area.y);
            float z = Random.Range(-Area.z, Area.z);
            nthCube.transform.position = new Vector3(x, y, z);
            float scaleX = Random.Range(-2, 2);
            float scaleY = Random.Range(-2, 2);
            float scaleZ = Random.Range(-2, 2);
            nthCube.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
		}
        for (int i = 0; i < numOfSpheres; i++)
        {
            GameObject nthSphere = Instantiate(SpherePrefab);
            float x = Random.Range(-Area.x, Area.x);
            float y = Random.Range(0, Area.y);
            float z = Random.Range(-Area.z, Area.z);
            nthSphere.transform.position = new Vector3(x, y, z);
            float scaleX = Random.Range(-2, 2);
            float scaleY = Random.Range(-2, 2);
            float scaleZ = Random.Range(-2, 2);
            nthSphere.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
