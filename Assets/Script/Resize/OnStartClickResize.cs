using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStartClickResize : MonoBehaviour
{

    public GameObject startButton;
    public GameObject currentboard;
    public GameObject currentText;
    public GameObject newboard;
    public GameObject newText;
    public AudioSource audioPlayer;

    public void clickStart()
    {
        currentboard.SetActive(false);
        currentText.SetActive(false);
        newboard.SetActive(true);
        newText.SetActive(true);
        audioPlayer.Play();
    }
}
