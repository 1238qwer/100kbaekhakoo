using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomQuit : MonoBehaviour
{
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            cube1.SetActive(!cube1.activeSelf);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            cube2.SetActive(!cube2.activeSelf);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            cube3.SetActive(!cube3.activeSelf);
        }
    }
}
