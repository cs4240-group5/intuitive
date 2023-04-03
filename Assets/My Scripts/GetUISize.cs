using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetUISize : MonoBehaviour
{
    public Slider slider;
    public RectTransform panelRectTransform;

    public float currentSize;
    public float currentSliderValue;

    public Text instructiontext;
    public Text boardtext;
    public GameObject textInst_1;
    public GameObject textInst_2;
    public bool rightWallTouch = false;

    private void Awake()
    {
        // Get a reference to the panel's RectTransform component
        panelRectTransform = GetComponent<RectTransform>();
    }

    void Start()
    {
        // Save the current height of the panel and the starting value of the slider
        currentSize = 1000;
        currentSliderValue = 50;        
        instructiontext.fontSize = 50;
    }

    void Update()
    {
        // Calculate the percentage change in the slider value
        
        if(slider.value != 50)
        {
            OnSliderValueChanged();
        }
        float percentageChange = (slider.value - 50) / 50;

        // Resize the panel based on the percentage change
        float newHeight = currentSize + currentSize * percentageChange;
        float newWidth = currentSize + currentSize * percentageChange;
        int newFontSize = 50 + Mathf.RoundToInt(percentageChange*50);
        instructiontext.fontSize = newFontSize;
        panelRectTransform.sizeDelta = new Vector2(newWidth, newHeight);

        boardtext.text = "Current Size: " + newHeight.ToString() + " X "
            + newHeight.ToString() + "\nCurrent Font Size: " + instructiontext.fontSize.ToString();

    }

    void OnSliderValueChanged()
    {
        textInst_1.SetActive(false);
        textInst_2.SetActive(true);
    }

}
