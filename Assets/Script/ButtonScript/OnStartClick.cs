using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStartClick : MonoBehaviour
{
    public GameObject startButton;
    public GameObject currentboard;
    public GameObject currentText;
    public GameObject newboard;
    public GameObject newText;
    public AudioSource audioPlayer;

    public void Start()
    {
        newboard.transform.localScale = Vector2.zero;
        newText.transform.localScale = Vector2.zero;
    }

    public void clickStart()
    {
        currentboard.transform.localScale = Vector2.zero;
        currentText.transform.localScale = Vector2.zero;
        //currentboard.SetActive(false);
        //currentText.SetActive(false);
        newboard.transform.LeanScale(Vector2.one, 0.2f);
        newText.transform.LeanScale(Vector2.one, 0.2f);
        audioPlayer.Play();
    }
}
