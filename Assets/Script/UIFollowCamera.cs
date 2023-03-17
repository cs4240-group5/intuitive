using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFollowCamera : MonoBehaviour
{
    public GameObject camera;
    public GameObject hud;

    private Vector3 offset;
    //private Vector3 angle;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - camera.transform.position;
       // angle = transform.rotation;
    }

    // Update is called once per frame
    void LateUpdate()
    {   
        // if (transform.rotation.compare(angle)) {
        //     transform.position += offset;
        // }
        transform.position = camera.transform.position + offset;
        transform.rotation = camera.transform.rotation;
    }
}
