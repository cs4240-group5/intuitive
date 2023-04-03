
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
        slider.minValue = 0;
        slider.maxValue = UIObjects.Length;
        slider.value = UIObjects.Length;

        for (int i = 0; i < UIObjects.Length; i++)
        {
            UIObjects[i].SetActive(false);
        }
    }

    void Update()
    {
        // Calculate the percentage change in the slider value


        int currentValue = (int)Math.Floor(slider.value);
        for (int i = 0; i < currentValue; i++)
        {
            UIObjects[i].SetActive(true);
        }
        for (int i = currentValue; i < slider.maxValue; i++)
        {
            UIObjects[i].SetActive(false);
        }
    }

}
