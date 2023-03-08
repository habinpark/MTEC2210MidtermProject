using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    public float moveSpeedMin = .01f;
    public float moveSpeedMax = .1f;
    public float moveSpeed;
    public float rotateSpeed = 1f;

    public bool shouldRotate = false;

    // Start is called before the first frame update
    void Start()
    {
        //set moveSpeed to a random number between moveSpeedMin and moveSpeedMax
        moveSpeed = Random.Range(moveSpeedMin, moveSpeedMax);
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, -1f * moveSpeed, 0,Space.World);
        //if shouldrotate is true rotate the object around the z axis in euler angles
        if (shouldRotate)
        {
            transform.Rotate(0, 0, rotateSpeed);
        }
    }
}
