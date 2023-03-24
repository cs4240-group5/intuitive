using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationPanel : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tipsPanel;
    public GameObject miniGamePanel;
    public GameObject explanationPanel;
    public GameObject selectionPanel;

    void Start()
    {
        tipsPanel.transform.localScale = Vector2.zero;
        miniGamePanel.transform.localScale = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickTipsPanel()
    {
        tipsPanel.transform.LeanScale(Vector2.one, 0.3f);
        explanationPanel.transform.localScale = Vector2.zero;
        selectionPanel.transform.localScale = Vector2.zero;
        miniGamePanel.transform.localScale = Vector2.zero;
    }


    // go back to selectionPanel.
    public void ClickExplanationPanel()
    {
        explanationPanel.transform.LeanScale(Vector2.zero, 0.3f);
        tipsPanel.transform.localScale = Vector2.zero;
        selectionPanel.transform.LeanScale(Vector2.one, 0.3f);
        miniGamePanel.transform.localScale = Vector2.zero;
    }

    public void ClickMiniGamePanel()
    {
        miniGamePanel.transform.LeanScale(Vector2.one, 0.3f);
        tipsPanel.transform.localScale = Vector2.zero;
        explanationPanel.transform.localScale = Vector2.zero;
    }
}
