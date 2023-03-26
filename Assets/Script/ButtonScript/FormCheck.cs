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

    public void OnPointerClick()
    {   
        GameObject selectedGameObject = EventSystem.current.currentSelectedGameObject;
        Image imageComponent = selectedGameObject.GetComponent<Image>();
        imageComponent.color = Color.green;
        if (isSelected)
        {   
            for (int i = 0; i < selectableOptions.Length; i++) 
            {
                if (selectableOptions[i] != selectedGameObject)
                {
                    Image currentImage = selectableOptions[i].GetComponent<Image>();
                    currentImage.color = Color.white;
                }
            }
        }
        isSelected = true;
    }
}
