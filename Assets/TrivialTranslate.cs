using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrivialTranslate : MonoBehaviour
{
    public float speed;
    public float _time;
    private float _currentTime;

    private bool down;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (down) {
            _currentTime -= Time.deltaTime;
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
            if (_currentTime <= 0) {
                down = false;
            }
        }
        else {
            _currentTime += Time.deltaTime;
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
            if (_currentTime >= _time) {
                down = true;
            }
        }
    }
}
