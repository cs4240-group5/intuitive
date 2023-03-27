using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FormCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] selectableOptions;
    public bool isSelected;
    void Start()
    {
        isSelected = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onButtonClick(GameObject clickedObject)
    {   
        Image imageComponent = clickedObject.GetComponent<Image>();
        imageComponent.color = Color.green;
        if (isSelected)
        {   
            for (int i = 0; i < selectableOptions.Length; i++) 
            {
                if (selectableOptions[i] != clickedObject)
                {
                    Image currentImage = selectableOptions[i].GetComponent<Image>();
                    currentImage.color = Color.white;
                }
            }
        }
        isSelected = true;
    }
}
