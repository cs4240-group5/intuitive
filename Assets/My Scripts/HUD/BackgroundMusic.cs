using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    AudioSource sceneMusic;
    // Start is called before the first frame update
    void Start()
    {
        sceneMusic = GetComponent<AudioSource>();
        sceneMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        sceneMusic.loop = true;
    }
}
