using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using UnityEditorInternal.VR;

public class TrivialRotate : MonoBehaviour
{
    public float speed;
    public float _time;
    private float _currentTime;

    private bool down;
    // Start is called before the first frame update
    void Start()
    {
        //VREditor.GetVREnabledDevicesOnTargetGroup
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("dd");
        transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
        //transform.Rotate(new Vector3(speed * Time.deltaTime, 0, 0));
        //transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime));
    }
}
