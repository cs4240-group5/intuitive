using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetToGrab : MonoBehaviour
{
    public GameObject controller;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        controller.GetComponent<ActivateGrab>().switchGrabHands(true);
    }
}
