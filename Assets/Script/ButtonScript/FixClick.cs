using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;

public class FixClick : MonoBehaviour
{
    // Start is called before the first frame update
    public Button fixButton;
    public GameObject currentPanel;
    public GameObject leftPanel;
    public GameObject rightPanel;
    public GameObject defaultText;
    public AudioSource audioPlayer;

    public void ClickStart()
    {
        currentPanel.SetActive(false);
        leftPanel.SetActive(true);
        rightPanel.SetActive(true);
        defaultText.SetActive(true);
        fixButton.interactable = false;
        audioPlayer.Play();
    }
}
