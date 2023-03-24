using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;

public class MoveToNext2 : MonoBehaviour
{
    public GameObject currentPanel;
    public GameObject newPanel;
    public AudioSource audioPlayer;
    public GameObject optionsSlider;
    public GameObject tipsSlider;

    void Start()
    {
        tipsSlider.transform.localScale = Vector2.zero;
        newPanel.transform.localScale = Vector2.zero;
    }

    public void clickNext()
    {
        currentPanel.transform.localScale = Vector2.zero;
        newPanel.transform.LeanScale(Vector2.one, 0.3f);
        optionsSlider.transform.localScale = Vector2.zero;
        tipsSlider.transform.localScale = Vector2.one;
        audioPlayer.Play();
    }
}
