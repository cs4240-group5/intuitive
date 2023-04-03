using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject target;
    //public AudioClip hitAudio;
    AudioSource targetMusic;

    private ScoreManager scoreManager;
    private int addPoint = 1;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
        targetMusic = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void targetHit()
    {
        //target.SetActive(false);
        //targetMusic.Play();
        //AudioSource.PlayClipAtPoint(targetMusic.clip, target.transform.position);
        target.transform.localScale = Vector3.zero;
        //scoreManager.AddPoint(addPoint);
        ScoreManager.instance.AddPoint(addPoint);
        //AudioSource.PlayClipAtPoint(hitAudio, transform.position);
        
    }
}
