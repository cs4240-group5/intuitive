using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFollowCameraLate : MonoBehaviour
{
    public GameObject camera;
    public GameObject hud;
    
    float timer, timer2;

    private float delay = 5f;
    private float delay2 = 0f;
    private Vector3 offset, startPos, endPos;
    private float startTime, endTime;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - camera.transform.position;
        //startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = camera.transform.position + offset;
        startTime = Time.time;
        startPos = camera.transform.position + offset;
        timer += Time.deltaTime;
        timer2 += Time.deltaTime;
        

        if (timer >= delay) {
            //transform.position = camera.transform.position + offset;
            endTime = Time.time;
            endPos = camera.transform.position + offset;
            timer -= delay;
        }
        if (timer2 >= delay2) {
            transform.position = Vector3.Lerp(startPos, endPos, (float) 0.05);
            //transform.position = camera.transform.position + offset;
            timer2 -= delay2;
        }
    }

    // private void Update() {
    //     timer += Time.deltaTime;

    //     if (timer > delay) {
    //         transform.position = camera.transform.position + offset;
    //         timer -= delay;
    //     }
    // }
}
