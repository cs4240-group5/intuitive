using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDunks : MonoBehaviour
{
    public Text text;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }
    private void OnTriggerEnter()
    {
        count++;
        text.text = "HOOP IT UP! " +
            "DUNKS: " + count;
    }

    public void ResetDunks()
    {
        count = 0;
        text.text = "HOOP IT UP! " +
            "DUNKS: " + count;
    }
}
