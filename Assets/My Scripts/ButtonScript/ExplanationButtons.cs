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



    public void clickExp()
    {
        
        audioPlayer.Play();
        text_1.SetActive(true);
        text_2.SetActive(false);
        text_3.SetActive(false);
        
    }

    public void clickSum()
    {
        audioPlayer.Play();
        text_2.SetActive(true);
        text_1.SetActive(false);
        text_3.SetActive(false);

    }

    public void clickNext()
    {
        audioPlayer.Play();
        text_3.SetActive(true);
        text_1.SetActive(false);
        text_2.SetActive(false);
    }
}
