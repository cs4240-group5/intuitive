using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UIFollowCamera : MonoBehaviour
{
    public GameObject camera;
    //public GameObject hud;
    //public Transform target;

    private Vector3 offset;
    private float angleDiff;
    private float currZ;
    private float newZ;
    private float currX;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - camera.transform.position;
        //angleDiff = Quaternion.Angle(GameObject.transform.rotation, camera.rotation);
        angleDiff = Quaternion.Angle(transform.rotation, camera.transform.rotation);
    }

    // Update is called once per frame
    void LateUpdate()
    {   
        angleDiff = Quaternion.Angle(transform.rotation, camera.transform.rotation);
        if (angleDiff < 0) {
            currZ = offset.z;
            newZ = currZ - currZ* (float) (Math.Cos(angleDiff));
            currX = currZ* (float) (Math.Sin(angleDiff));
            transform.position = new Vector3(transform.position.x - currX, 0.0f, currZ - newZ);
            transform.rotation = camera.transform.rotation;
        }  else if (angleDiff == 0) {
            transform.position = camera.transform.position + offset;
            transform.rotation = camera.transform.rotation;
        } else if (angleDiff > 0) {
            currZ = offset.z;
            newZ = currZ - currZ* (float) (Math.Cos(angleDiff));
            currX = currZ* (float) (Math.Sin(angleDiff));
            transform.position = new Vector3(transform.position.x + currX, 0.0f, currZ - newZ);
            transform.rotation = camera.transform.rotation;
        } else {}
        // transform.position = camera.transform.position + offset;
         transform.RotateAround(camera.transform.position, Vector3.up, angleDiff);
    }
}
