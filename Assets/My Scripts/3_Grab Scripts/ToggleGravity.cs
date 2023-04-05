using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleGravity : MonoBehaviour
{
    // All gameobjects
    private GameObject[] gameObjects;

    public bool isGravityOn;
    public Text objectText;
    // Start is called before the first frame update
    void Start()
    {
        isGravityOn = true;

        //Find GameObjects with Reset Position (applying to the same objects so reuse tag)
        gameObjects = GameObject.FindGameObjectsWithTag("Reset Positions");
    }

    public void setGravity()
    {
        if (isGravityOn)
        {
            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].GetComponent<Rigidbody>().useGravity = false;
            }
            objectText.text = "GRAVITY: OFF";
            isGravityOn = false;
        } else
        {
            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].GetComponent<Rigidbody>().useGravity = true;
            }
            objectText.text = "GRAVITY: ON";
            isGravityOn = true;
        }

    }
}
