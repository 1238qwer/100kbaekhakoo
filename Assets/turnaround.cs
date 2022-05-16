using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnaround : MonoBehaviour
{
    public float speed;
    public GameObject obj;
    public Vector3 vec;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.RotateAround(obj.transform.position, vec, speed * Time.deltaTime);
    }
}
