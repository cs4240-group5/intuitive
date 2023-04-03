using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class resizeQuestion : MonoBehaviour
{
    public Slider slider;
    public RectTransform panelRectTransform;
    public float currentSize = 200;
    public float fixedWidth = 300;
    public GameObject instructPanel;
    public Text answerText;
    public Button[] numberButtons;
    public Button buttonReset;
    public Button buttonEnter;

    public string correctSequence = "4992";
    private string currentSequence = "";
    
    public DoorScript dooropen;
    public GameObject animationobject;
    public void Awake()
    {
        // Get a reference to the panel's RectTransform component
        panelRectTransform = GetComponent<RectTransform>();
    }

    public void Start()
    {
        foreach (Button button in numberButtons)
        {
            button.onClick.AddListener(() => AddToSequence(button.name));
        }

    }
    void AddToSequence(string buttonName)
    {
        currentSequence += buttonName;
        answerText.text = currentSequence;

        if (currentSequence.Length == 4)
        {
            foreach (Button button in numberButtons)
            {
                button.interactable = false;
            }
        }
    }
    public void ConfirmSequence()
    {
         if (currentSequence == correctSequence)
        {
            answerText.text = "CORRECT";
            animationobject.GetComponent<Animation>().Play();
            dooropen.PlayAnimation();
        }
        else
        {
            currentSequence = "";
            answerText.text = "Wrong";
            foreach (Button button in numberButtons)
            {
                button.interactable = true;
            }
        }
    }

    public void ResetSequence()
    {
        currentSequence = "";
        answerText.text = currentSequence;
    }

    // Update is called once per frame
    public void Update()
    {
        float percentageChange = (slider.value) / 100;
        // Resize the panel based on the percentage change
        float newHeight = currentSize + currentSize * percentageChange;
        panelRectTransform.sizeDelta = new Vector2(fixedWidth, newHeight);
    }

}
