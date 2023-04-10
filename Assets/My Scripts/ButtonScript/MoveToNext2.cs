using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;

public class MoveToNext2 : MonoBehaviour
{
    public Text textBoard;
    public GameObject panel2UpPanel;
    public GameObject rightPanel;
    public GameObject currentPanel;
    public GameObject newPanel;
    public AudioSource audioPlayer;
    public GameObject optionsSlider;
    public GameObject tipsSlider;

    public GameObject tipsPanel;
    public GameObject miniGamePanel;
    public GameObject explanationPanel;
    public GameObject selectionPanel;

    void Start()
    {
        panel2UpPanel.transform.localScale = Vector2.zero;
        tipsSlider.transform.localScale = Vector2.zero;
        newPanel.transform.localScale = Vector2.zero;

        // next panel
        explanationPanel.transform.localScale = Vector2.zero;
        tipsPanel.transform.localScale = Vector2.zero;
        selectionPanel.transform.localScale = Vector2.zero;
        tipsPanel.transform.localScale = Vector2.zero;
        miniGamePanel.transform.localScale = Vector2.zero;
    }

    public void clickNext()
    {
        currentPanel.transform.localScale = Vector2.zero;
        newPanel.transform.LeanScale(Vector2.one, 0.3f);
        optionsSlider.transform.localScale = Vector2.zero;
        tipsSlider.transform.localScale = new Vector2(2.5f, 2.5f);
        audioPlayer.Play();

        explanationPanel.transform.LeanScale(Vector2.one, 0.3f);
        //tipsPanel.transform.LeanScale(Vector2.zero, 0.3f);
        selectionPanel.LeanScale(Vector2.one, 0.3f);
        rightPanel.transform.localScale = Vector2.zero;
        panel2UpPanel.transform.localScale = Vector2.one;
        textBoard.text = "Hick's Law";
        //textBoard.transform.localScale = Vector2.zero;
    //tipsPanel.LeanScale(Vector2.zero, 0.3f);
    //miniGamePanel.LeanScale(Vector2.zero, 0.3f);
}
}
