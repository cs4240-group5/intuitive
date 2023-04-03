using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceSlider : MonoBehaviour
{
    public Slider distanceSlider;
    private Vector3 originalPos;
    private double distance;
    public GameObject refObj;
    private double minRange = 1.0;
    private readonly double maxRange = 3.0;
    public GameObject tick;
    public GameObject cross;
    public float directionX;
    public float directionZ;

    // Start is called before the first frame update
    void Start()
    {
        originalPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(originalPos.x + directionX * distanceSlider.value, originalPos.y, originalPos.z + directionZ * distanceSlider.value);
        this.transform.position = newPos;

        distance = Vector3.Distance(refObj.transform.position, this.transform.position);
        if (distance >= minRange && distance <= maxRange)
        {
            tick.SetActive(true);
            cross.SetActive(false);
        } else
        {
            tick.SetActive(false);
            cross.SetActive(true);
        }
    }
}
