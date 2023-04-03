using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleDisplay : MonoBehaviour
{
    public GameObject display1;
    public GameObject display2;
    private bool curr = true;

    public void toggleDisplay()
    {
        display1.SetActive(!curr);
        display2.SetActive(curr);
        curr = !curr;
    }
}
