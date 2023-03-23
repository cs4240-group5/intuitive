using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCount : MonoBehaviour
{
    public GameObject targetParent;
    public float delay = 1;
    float timer;
    private int totalTargetCounts;

    // Update is called once per frame
    void Update()
    {
        totalTargetCounts = 0;

        foreach (Transform child in targetParent.transform)
        {
            // If the child object is active, increment the active child count
            if (child.gameObject.activeSelf)
            {
                totalTargetCounts++;
            }
        }   

        if (totalTargetCounts == 0) {
            timer += Time.deltaTime;

            if (timer > delay) {
                foreach (Transform child in targetParent.transform) 
                {
                    child.gameObject.SetActive(true);
                }
            }
            //timer = 0;
        }

        if (timer > delay) {
            timer = 0;
        }
    }
}
