
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GetUI : MonoBehaviour
{
    public Slider slider;
    public GameObject[] UIObjects;

    void Start()
    {
        // Save the current height of the panel and the starting value of the slider
        slider.minValue = 0;
        slider.maxValue = UIObjects.Length;
        slider.value = UIObjects.Length;

        // disable second text object.
        for (int i = 0; i < UIObjects.Length; i++)
        {
            UIObjects[i].transform.localScale = Vector3.zero;
        }
    }

    void Update()
    {
        // Calculate the percentage change in the slider value


        int currentValue = (int)Math.Floor(slider.value);
        for (int i = 0; i < currentValue; i++)
        {
            UIObjects[i].transform.LeanScale(Vector3.one, 0.2f);
        }
        for (int i = currentValue; i < slider.maxValue; i++)
        {
            UIObjects[i].LeanScale(Vector3.zero, .2f).setEaseInBack();
        }
    }

}
