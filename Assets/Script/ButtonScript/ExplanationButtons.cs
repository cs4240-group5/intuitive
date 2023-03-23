using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExplanationButtons : MonoBehaviour
{
    // Start is called before the first frame update
    
    public AudioSource audioPlayer;

    public Button expButton;
    public Button sumButton;
    public Button nextButton;

    public GameObject text_1;
    public GameObject text_2;
    public GameObject text_3;

    public bool flag_1 = true;
    public bool flag_2 = false;
    public bool flag_3 = false;

    public Button openButton;


    void clickExp()
    {
        
        audioPlayer.Play();
        flag_1 = true;
        text_1.SetActive(true);
        text_2.SetActive(false);
        text_3.SetActive(false);

        if (flag_1 && flag_2 && flag_3)
        {
            openButton.interactable = true;
        }
        
    }

    void clickSum()
    {
        audioPlayer.Play();
        flag_2 = true;        
        text_2.SetActive(true);
        text_1.SetActive(false);
        text_3.SetActive(false);

        
        if (flag_1 && flag_2 && flag_3)
        {
            openButton.interactable = true;
        }
    }

    void clickNext()
    {
        audioPlayer.Play();
        flag_3 = true;
        text_3.SetActive(true);
        text_1.SetActive(false);
        text_2.SetActive(false);

        if (flag_1 && flag_2 && flag_3)
        {
            openButton.interactable = true;
        }
    }
}
