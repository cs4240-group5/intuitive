using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCount : MonoBehaviour
{
    public GameObject targetParent;
    public GameObject[] targets;
    public float delay = 1;
    float timer;
    private int totalTargetCounts;

    // Update is called once per frame
    void Update()
    {
        totalTargetCounts = targets.Length;

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
                //for (int i = 0; i < targets.Length; i++)
                {
                    //child.gameObject.transform.localScale = new Vector3(20, 20, 20);
                    //targets[i].transform.localScale = new Vector3(20f, 20f, 20f);
                    //child.gameObject.transform.localScale = Vector3.one;
                    //child.gameObject.SetActive(true);
                }
            }
            //timer = 0;
        }

        if (timer > delay) {
            timer = 0;
        }
    }


    public void RespawnTargets()
    {
        for (int i = 0; i < targets.Length; i++)
        {
            targets[i].transform.localScale = new Vector3(20f, 20f, 20f);
        }
    }
}
