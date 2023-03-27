using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPicture : MonoBehaviour
{
    public Renderer objectRenderer;

    // Start is called before the first frame update
    void Start()
    {
        objectRenderer = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter (Collision other) {
    
        if (gameObject.tag == "picture_1" && other.gameObject.tag == "check_1" ) {
    
            objectRenderer.material.color = Color.green;
    
        } else if (gameObject.tag == "picture_2" && other.gameObject.tag == "check_2" ) {
    
            print ("hooray");
    
        } else if (gameObject.tag == "picture_3" && other.gameObject.tag == "check_3" ) {
    
            print ("hooray");
    
        } else if (gameObject.tag == "picture_4" && other.gameObject.tag == "check_4" ) {
    
            print ("hooray");
    
        }
    }
}
