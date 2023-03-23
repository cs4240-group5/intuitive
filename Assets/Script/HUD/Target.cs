using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject target;

    private ScoreManager scoreManager;
    private int addPoint = 1;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void targetHit()
    {
        target.SetActive(false);
        //scoreManager.AddPoint(addPoint);
        ScoreManager.instance.AddPoint(addPoint);
    }
}
