using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTeleport : MonoBehaviour
{
    public GameObject Ui; //test if teleport is working anot

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sceneTeleportStartingRoom() {
        SceneManager.LoadScene("StartingRoom");
        Ui.SetActive(true);
    }

    public void sceneTeleportHUD() {
        SceneManager.LoadScene("HUD");
        Ui.SetActive(true);
    }
}
