using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGrab : MonoBehaviour
{
    GameObject[] grabHands;
    private bool isGrabHands;

    GameObject[] distanceGrabHands;
    // Start is called before the first frame update
    void Start()
    {
        isGrabHands = true;
        //Find GameObjects with Reset Position (applying to the same objects so reuse tag)
        grabHands = GameObject.FindGameObjectsWithTag("NormalGrab");
        distanceGrabHands = GameObject.FindGameObjectsWithTag("DistanceGrab");

        switchGrabHands(isGrabHands);
    }

    public void switchGrabHands(bool isGrab)
    {
        if (!isGrabHands && isGrab)
        {
            for (int i = 0; i < distanceGrabHands.Length; i++)
            {
                distanceGrabHands[i].SetActive(false);
            }
            for (int i = 0; i < grabHands.Length; i++)
            {
                grabHands[i].SetActive(true);
            }
            isGrabHands = true;

        } else if (isGrabHands && !isGrab) // is already grabHands, set to Distance Grab
        {
            for (int i = 0; i < distanceGrabHands.Length; i++)
            {
                distanceGrabHands[i].SetActive(true);
            }
            for (int i = 0; i < grabHands.Length; i++)
            {
                grabHands[i].SetActive(false);
            }
            isGrabHands = false;
        }
    }
}
