using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeightSlider : MonoBehaviour
{
    public Slider distanceSlider; 
    private Vector3 originalPos;
    private double distance;

    public float movementSpeed = 1f; // Speed of movement of shelf

    private bool isUp;
    private bool isDown;

    // Start is called before the first frame update
    void Start()
    {
        originalPos = this.transform.position;
        isUp = false;
        isDown = false;
    }

    // Update is called once per frame
    void Update()
    {

        float ySpeed = 0.0f;
        if (isUp)
        {
            ySpeed = 1.0f;
        }

        if (isDown)
        {
            ySpeed = -1.0f;
        }

        Vector3 addedPos = new Vector3(
                0,
                ySpeed, // It's actually directly mapped
                0);

        Vector3 nextPos = this.transform.position + addedPos * movementSpeed * Time.deltaTime;

        if (nextPos.y < 3.75 && nextPos.y > 0.25)
        {
            GetComponent<Rigidbody>().MovePosition(nextPos);
        }
    }

    public void setUpToTrue()
    {
        isUp = true;
        isDown = false;
    }

    public void setUpToFalse()
    {
        isUp = false;
    }

    public void setDownToTrue()
    {
        isDown = true;
        isUp = false;
    }

    public void setDownToFalse()
    {
        isDown = false;
    }
}
