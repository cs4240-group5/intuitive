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

    // Start is called before the first frame update
    void Start()
    {
        originalPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 addedPos = new Vector3(
                0,
                distanceSlider.value, // It's actually directly mapped
                0);

        Vector3 maxPos = new Vector3(
                originalPos.x,
                3.75f,
                originalPos.z);
        Vector3 minPos = new Vector3(
                originalPos.x,
                0.25f,
                originalPos.z);

        Vector3 nextPos = this.transform.position + addedPos * movementSpeed * Time.deltaTime;

        if (nextPos.y < 3.75 && nextPos.y > 0.25)
        {
            GetComponent<Rigidbody>().MovePosition(nextPos);
        }
    }
}
