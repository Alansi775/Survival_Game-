using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{

    public float moveSpeed = 7.0f;
    public float turnspeed = 80.0f;

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveVertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(moveHorizontal, 0, moveVertical);

        if (Input.GetAxis("Mouse X") != 0)
        {
            float turn = Input.GetAxis("Mouse X") * turnspeed * Time.deltaTime;
            transform.Rotate(0, turn, 0, Space.World);
        }
    }

}