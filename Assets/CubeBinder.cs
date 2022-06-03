using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBinder : MonoBehaviour
{
    public Transform[] gameObjects;
    public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        //gameObjects = Transform.FindObjectsOfType<GameObject>();
        gameObjects = GetComponentsInChildren<Transform>();

        //GameObject temp = Instantiate(particle, gameObjects[0].transform);
        foreach (var item in gameObjects) {
            if (item.gameObject.activeSelf && item != gameObject.transform) {
                GameObject temp = Instantiate(particle);

                temp.transform.parent = item.transform;
                temp.transform.localPosition = Vector3.zero;
                //temp.transform.position = item.transform.position;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
