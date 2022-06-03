using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    private Vector3 rotateVec;
    // Update is called once per frame
    private void Start() {
        transform.Rotate(Random.Range(10, 45), Random.Range(10, 45), Random.Range(10, 45));

        //rotateVec = new Vector3(Random.Range(0, 3), Random.Range(0, 3), Random.Range(0, 3));

        rotateVec = new Vector3(30, 30, 30);
    }
    void FixedUpdate()
    {
        transform.Rotate(rotateVec * Time.deltaTime);
    }
}
