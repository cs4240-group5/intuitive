using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SlideShow : MonoBehaviour
{
    public string[] messages;
    private int index = 0;
    
    public static GameObject textUI;
    private TextMeshProUGUI textVar;

    void Start() {
        textUI = GameObject.Find("BoardSlide");
        textVar = textUI.GetComponent<TextMeshProUGUI>();
        textVar.text = messages[index];
    }

    public void messageIncrement() {
        // Loop back if required
        index = (index + 1) % messages.Length;

        textVar.text = messages[index];
    }

    public void messageDecrement() {
        // Loop back if required
        index = (index - 1) % messages.Length;

        textVar.text = messages[index];
    }
}
