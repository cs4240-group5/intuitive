using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resizeTester : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public RectTransform panelRectTransform;
 //   public RectTransform panelRectTransform2;
 //   public RectTransform panelRectTransform3;

    public Button fontButton;
    public Button panelButton;
 //   public Button buttonButton;

    public int currentFontSize = 50;
    public float currentPanelSizeWidth = 1000;
    public float currentPanelSizeHeight = 500;
 //   public float currentButtonSizeWidth = 300;
 //   public float currentButtonSizeHeight = 200;

    public float fontSliderValue;
    public float panelSliderValue;
 //   public float buttonSliderValue;

    public bool font = false;
    public bool panel = false;
 //   public bool button = false;
    
    public Text textchange;

    void Start()
    {
        panelRectTransform = GetComponent<RectTransform>();
        //panelRectTransform2 = GetComponent<RectTransform>();
        //panelRectTransform3 = GetComponent<RectTransform>();
    }

    public void ClickFont()
    {
        slider.interactable = true;
        font = true;
        panel = false;
        //button = false;
        fontButton.interactable = false;

        panelButton.interactable = true;
        //buttonButton.interactable = true;

        slider.value = fontSliderValue;

    }

    public void ClickPanel()
    {
        slider.interactable = true;
        font = false;
        panel = true;
        //button = false;
        panelButton.interactable = false;
        slider.value = panelSliderValue;

        fontButton.interactable = true;
        //buttonButton.interactable = true;
    }

    /*public void ClickButton()
    {
        slider.interactable = true;
        font = false;
        panel = false;
        button = true;
        buttonButton.interactable = false;
        slider.value = buttonSliderValue;

        fontButton.interactable = true;
        panelButton.interactable = true;
    }*/

    // Update is called once per frame

    public void Update()
    {
        if (font)
        {
            int percentageChange = Mathf.RoundToInt((slider.value) - 100);
            textchange.fontSize = currentFontSize + percentageChange;
            fontSliderValue = slider.value;
        }
        else if (panel)
        {
            float percentageChange = (slider.value) / 100;
            float newWidth = currentPanelSizeWidth * percentageChange;
            float newHeight = currentPanelSizeHeight * percentageChange;
            panelRectTransform.sizeDelta = new Vector2(newWidth, newHeight);
            panelSliderValue = slider.value;
        }
  /*      else if (button)
        {
            float percentageChange = (slider.value) / 100;
            float newWidth = currentButtonSizeWidth * percentageChange;
            float newHeight = currentButtonSizeHeight * percentageChange;
            panelRectTransform2.sizeDelta = new Vector2(newWidth, newHeight);
            panelRectTransform3.sizeDelta = new Vector2(newWidth, newHeight);
            buttonSliderValue = slider.value;
        } */
        else
        {
            slider.interactable = false;
        }
    }
}
