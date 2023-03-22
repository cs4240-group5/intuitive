
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetOptions : MonoBehaviour
{
    public Slider slider;
    //public GameObject options;

    public Text boardtext;
    public GameObject[] buttonObjects;
    public GameObject textInst_1;
    public GameObject textInst_2;

    private void Awake()
    {
        // Get a reference to the panel's RectTransform component
        //options = GameObject.Find("Options");
    }

    void Start()
    {
        // Save the current height of the panel and the starting value of the slider
        slider.value = buttonObjects.Length;    
    }

    void Update()
    {
        // Calculate the percentage change in the slider value
        
        if(slider.value != buttonObjects.Length)
        {
            OnSliderValueChanged();
        }
        int currentValue = (int)Math.Floor(slider.value);
        for (int i = 0; i < currentValue; i++) {
            buttonObjects[i].SetActive(true);
        }
        for (int i = currentValue; i < slider.maxValue; i++) {
            buttonObjects[i].SetActive(false);
        }

        boardtext.text = "Current Option Count: " + currentValue;

    }

    void OnSliderValueChanged()
    {
        textInst_1.SetActive(false);
        textInst_2.SetActive(true);
    }

}
