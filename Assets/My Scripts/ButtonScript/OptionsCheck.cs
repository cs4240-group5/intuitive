using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsCheck : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Slider slider;
    public GameObject checkButton;
    public GameObject moveonButton;
    public Text currentText;
    public AudioSource audioPlayer;

    public void Start()
    {
        moveonButton.transform.localScale = Vector2.zero;
    }
    // Update is called once per frame
    public void CheckAnswer()
    {
        audioPlayer.Play();
        if (slider.value < 4)
        {
            currentText.text = "Too Little! \nTry again.";
        }
        else if (slider.value > 6)
        {
            currentText.text = "Too Many! \nTry again.";
        }
        else
        {
            currentText.text = "Nice answer! \nClick to move on.";
            checkButton.transform.localScale = Vector2.zero;
            moveonButton.transform.localScale = Vector2.one;
        }
        
    }
}
