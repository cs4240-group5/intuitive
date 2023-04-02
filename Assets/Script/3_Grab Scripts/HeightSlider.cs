using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeightSlider : MonoBehaviour
{
    public Slider distanceSlider; 
    private Vector3 originalPos;
    private double distance;
    public GameObject refObj;
    
    // private double minRange = 1.0;
    // private double maxRange = 3.0;



    // Start is called before the first frame update
    void Start()
    {
        originalPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(
                originalPos.x,
                distanceSlider.value, // It's actually directly mapped
                originalPos.z);
        this.transform.position = newPos;

        // distance = Vector3.Distance(refObj.transform.position, this.transform.position);
    }
}
