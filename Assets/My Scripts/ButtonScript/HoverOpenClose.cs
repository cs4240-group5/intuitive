using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOpenClose : MonoBehaviour
{   
    public AudioSource hoverSound;
    // Start is called before the first frame update
    public void Start()
    {
        transform.localScale = Vector2.zero;
    }

    public void Open() {
        hoverSound.Play();
        transform.LeanScale(Vector2.one, 0.5f);
    }

    public void Close() {
        transform.LeanScale(Vector2.zero, .5f).setEaseInBack();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
