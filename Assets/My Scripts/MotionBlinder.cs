using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class MotionBlinder : MonoBehaviour
{
    public GameObject blinder;
    public OVRInput.Controller LController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("moveHorizontal") > 0 || Input.GetAxis("moveHorizontal") < 0 || Input.GetAxis("moveVertical") > 0 || Input.GetAxis("moveVertical") < 0)
        {
            blinder.SetActive(true);
        } else
        {
            blinder.SetActive(false);
        }
        
    }
}
