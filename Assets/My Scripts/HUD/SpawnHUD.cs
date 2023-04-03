using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnHUD : MonoBehaviour
{
    public GameObject hud, startWall, fixedHUD, spawnToggleHUD, spawnHUD;
    private bool toggle = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void toggleHUD() {
        hud.SetActive(false);
        startWall.SetActive(false);
        spawnHUD.SetActive(toggle);
        spawnToggleHUD.SetActive(true);
        fixedHUD.SetActive(!toggle);
        toggle = !toggle;
    }

    /*
    public void toggleHUD()
    {
        hud.SetActive(toggle);
        fixedHUD.SetActive(!toggle);
        toggle != toggle;
    }
    */

    /*
    public void despawnHUD() {
        hud.SetActive(false);
        fixedHUD.SetActive(false);
    }

    public void spawnFixedHUD() {
        hud.SetActive(false);
        fixedHUD.SetActive(true);
    }
    */
}
