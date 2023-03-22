using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTeleport : MonoBehaviour
{
    public GameObject Ui;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sceneTeleport() {
        SceneManager.LoadScene("Oculus");
    }

    public void spawnUI() {
        Ui.SetActive(true);
    }
}
