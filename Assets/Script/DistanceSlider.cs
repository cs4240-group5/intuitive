using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceSlider : MonoBehaviour
{
    public Slider distanceSlider;
    private Vector3 originalPos;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(originalPos.x, originalPos.y, originalPos.z + distanceSlider.value);
        this.transform.position = newPos;
    }
}
