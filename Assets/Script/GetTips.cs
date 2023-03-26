
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
        slider.maxValue = tips.Length;
    }

    void Update()
    {
        // Calculate the percentage change in the slider value
        int currentValue = (int)Math.Floor(slider.value);
        for (int i = 0; i < currentValue; i++) {
            tips[i].SetActive(true);
        }
        for (int i = currentValue; i < slider.maxValue; i++) {
            tips[i].SetActive(false);
        }

        boardtext.text = "";

    }

}
