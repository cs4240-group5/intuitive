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
        text.text = "HOOP IT UP!" +
            "DUNKS: " + count;
    }
}
