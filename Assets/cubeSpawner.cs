using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeSpawner : MonoBehaviour
{
    public GameObject cubes;
    public GameObject cube;

    public float intervalHorizon;
    public float intervalVertical;

    public Vector3 vec;

    private float vertical = 5.79f;
    // Start is called before the first frame update
    void Start() {
        for (int j = 0; j < 23; j++) {
            for (int i = 0; i < 30; i++) {
                GameObject temp = Instantiate(cube, cubes.transform);
                temp.transform.localPosition = new Vector3(vec.x + (intervalHorizon * i), vertical, vec.z);
            }

            vertical -= intervalVertical;
        }

        //for (int i = 0; i < 30; i++) {
        //    GameObject temp = Instantiate(cube, cubes.transform);
        //    temp.transform.localPosition = new Vector3(vec.x + (intervalHorizon * i), vec.y, vec.z);

        //    for (int j =0; j < 20; j++) {
        //        GameObject temp2 = Instantiate(cube, cubes.transform);
        //        temp2.transform.localPosition = new Vector3(vec.x + (intervalHorizon * i), vec.y - (intervalVertical * i), vec.z);
        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
