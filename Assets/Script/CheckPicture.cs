using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPicture : MonoBehaviour
{
    public GameObject checker_1;
    public GameObject checker_2;
    public GameObject checker_3;
    public GameObject checker_4;

    // Start is called before the first frame update
    void Start()
    {
        //objectRenderer = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void OnCollisionEnter(Collision other) {
        if (gameObject.CompareTag("Picture_3"))
        {
            print("colliding with picture 3");
            checker_1.GetComponent<MeshRenderer>().material.color = Color.green;
        }

        if (gameObject.CompareTag("Picture_1") && other.gameObject.CompareTag("Pin_1") ) {
    
            print("collide 1");
            checker_1.GetComponent<MeshRenderer>().material.color = Color.green;
    
        } else if (gameObject.CompareTag("Picture_2") && other.gameObject.CompareTag("Pin_2") ) {
    
            print("collide 2");
            checker_2.GetComponent<MeshRenderer>().material.color = Color.green;
    
        } else if (gameObject.CompareTag("Picture_3") && other.gameObject.CompareTag("Pin_3") ) {
    
            print("collide 3");
            checker_3.GetComponent<MeshRenderer>().material.color = Color.green;
    
        } else if (gameObject.CompareTag("Picture_4") && other.gameObject.CompareTag("Pin_4") ) {
    
            print("collide 4");
            checker_4.GetComponent<MeshRenderer>().material.color = Color.green;
    
        }
    }
}
