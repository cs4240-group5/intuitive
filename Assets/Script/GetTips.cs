
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTips : MonoBehaviour
{
    public Slider slider;

    public Text boardtext;
    public GameObject[] tips;

    void Start()
    {
        // Save the current height of the panel and the starting value of the slider
        slider.value = 0;
        slider.minValue = 0;
        slider.maxValue = tips.Length - 1;

        // hide all tips
        for (int i = 0; i < slider.maxValue + 1; i++) {
            tips[i].transform.localScale = Vector2.zero;
        }
    }

    void Update()
    {
        // Calculate the percentage change in the slider value
        int currentValue = (int)Math.Floor(slider.value);
        tips[currentValue].transform.LeanScale(Vector2.one, 0.3f);


        for (int i = 0; i < slider.maxValue + 1; i++) {
            if (i == currentValue) {
                continue;
            }
            tips[i].transform.localScale = Vector2.zero;
        }
        boardtext.text = "";

    }

}
