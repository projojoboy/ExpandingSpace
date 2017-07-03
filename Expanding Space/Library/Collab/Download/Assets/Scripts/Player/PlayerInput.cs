using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    Laser[] laser;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKey("joystick button 0"))
        {
            foreach (Laser l in laser)
            {
                //  Vector3 pos = transform.position + (transform.forward * l.Distance);
                l.FireLaser();
            }
        }
    }
}
