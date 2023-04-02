using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;

public class MoveToNext : MonoBehaviour
{
    public GameObject nextButton;
    public GameObject currentboard;
    public GameObject currentText;
    public GameObject newboard;
    public GameObject newText;
    public Button openButton;
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
