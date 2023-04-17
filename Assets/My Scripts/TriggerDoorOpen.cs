using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerDoorOpen : MonoBehaviour
{
    public GameObject door;

    private void OnTriggerEnter()
    {
        door.GetComponent<DoorScript>().PlayAnimation();
    }
}
