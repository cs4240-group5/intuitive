using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class MotionBlinder : MonoBehaviour
{
    public GameObject LBlinder, RBlinder;

    private Vector3 startPosL, startPosR;
    private float time = 0f;
    private float duration = 1f; 
    private Vector3 endPosL = new Vector3(-0.16f, 0f, 0.16f);
    private Vector3 endPosR = new Vector3(0.16f, 0f, 0.16f);
    private float t = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
        startPosL = LBlinder.transform.position;
        startPosR = RBlinder.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("moveHorizontal") > 0 || Input.GetAxis("moveHorizontal") < 0 || 
            Input.GetAxis("moveVertical") > 0 || Input.GetAxis("moveVertical") < 0 ||
            Input.GetAxis("moveHorizontalKey") > 0 || Input.GetAxis("moveHorizontalKey") < 0 || 
            Input.GetAxis("moveVerticalKey") > 0 || Input.GetAxis("moveVerticalKey") < 0)
        {
            //LBlinder.transform.position = new Vector3(Mathf.Lerp(-0.16f, 0.5f, 0.0f), 0, 0.16f);
            // LBlinder.transform.position = Vector3.Lerp(startPosL, endPosL, time/duration);
            // RBlinder.transform.position = Vector3.Lerp(startPosR, endPosR, time/duration);
            var pos = LBlinder.transform.position;
            pos.x = Mathf.Lerp(-0.5f, -0.16f, t);
            LBlinder.transform.position = pos;
            t += Time.deltaTime;
            // time += Time.deltaTime;

            // if (time > duration) {
            //     time = 1;
            // }
            if (t >= 1f) {
                t = 1f;
            }
        } else
        {   
            
            // LBlinder.transform.position = Vector3.Lerp(startPosL, LBlinder.transform.position, time/duration);
            // RBlinder.transform.position = Vector3.Lerp(startPosR, RBlinder.transform.position, time/duration);
            // time -= Time.deltaTime;
            //LBlinder.transform.position = new Vector3(Mathf.Lerp(-0.5f, LBlinder.transform.position.x, 0), 0f, 0.16f);
            var pos = LBlinder.transform.position;
            pos.x = Mathf.Lerp(-0.5f, -0.16f, t);
            LBlinder.transform.position = pos;
            t -= Time.deltaTime;
            // if (time < 0) {
            //     time = 0;
            // }
            if (t < 0f) {
                t = 0f;
            }
        }
    }
}
