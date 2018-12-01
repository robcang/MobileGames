using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class DriveCar : MonoBehaviour
{

    public float speed = 1f;
    public float moveSpeed;

    void FixedUpdate()
    {
        float leftRight = CrossPlatformInputManager.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        transform.Translate(leftRight, 0, speed);
    }
}
