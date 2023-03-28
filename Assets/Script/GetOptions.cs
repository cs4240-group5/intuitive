
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

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
        slider.minValue = 0;
        slider.maxValue = buttonObjects.Length;
        slider.value = 0;

        // disable second text object.
        textInst_2.transform.localScale = Vector2.zero;
        for (int i = 0; i < buttonObjects.Length; i++)
        {
            buttonObjects[i].transform.localScale = Vector2.zero;
            Image imageComponent = buttonObjects[i].GetComponent<Image>();
            imageComponent.color = new Color(Random.value, Random.value, Random.value);
        }
    }

    void Update()
    {
        // Calculate the percentage change in the slider value
        
        if(slider.value != 0)
        {
            OnSliderValueChanged();
        }
        int currentValue = (int)Math.Floor(slider.value);
        for (int i = 0; i < currentValue; i++) {
            buttonObjects[i].transform.LeanScale(Vector2.one, 0.2f);
        }
        for (int i = currentValue; i < slider.maxValue; i++) {
            buttonObjects[i].LeanScale(Vector2.zero, .2f).setEaseInBack();
        }

        boardtext.text = "Current Option Count: " + currentValue;

    }

    void OnSliderValueChanged()
    {
        textInst_1.transform.localScale = Vector2.zero;
        textInst_2.transform.LeanScale(Vector2.one, 0.2f);
    }


}
