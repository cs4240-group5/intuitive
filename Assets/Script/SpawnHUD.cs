using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnHUD : MonoBehaviour
{
    public GameObject hud, slowHUD, fixedHUD, slowUI, fixedUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void spawnHUD() {
        hud.SetActive(true);
        slowUI.SetActive(true);
        fixedUI.SetActive(true);
    }

    public void spawnSlowHUD() {
        hud.SetActive(false);
        slowHUD.SetActive(true);
        fixedHUD.SetActive(false);
    }

    public void spawnFixedHUD() {
        hud.SetActive(false);
        slowHUD.SetActive(false);
        fixedHUD.SetActive(true);
    }
}
