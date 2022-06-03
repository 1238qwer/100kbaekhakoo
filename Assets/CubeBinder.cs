using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBinder : MonoBehaviour
{
    public GameObject[] gameObjects;
    public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        gameObjects = Transform.FindObjectsOfType<GameObject>();

        //GameObject temp = Instantiate(particle, gameObjects[0].transform);
        //foreach (var item in gameObjects) {
        //    GameObject temp = Instantiate(particle);
        //    temp.transform.position = item.transform.position;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
