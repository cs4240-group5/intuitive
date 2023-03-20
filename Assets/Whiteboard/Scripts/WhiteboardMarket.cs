using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class WhiteboardMarker : MonoBehaviour
{
    [SerializeField] private Transform tip;
    [SerializeField] private int penSize = 5;
    private Renderer renderer;
    private Color[] colors;
    private float tipHeight;
    private RaycastHit touch;
    private Whiteboard whiteboard;
    private Vector2 touchPos;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        colors = Enumerable.Repeat(renderer.material.color, penSize * penSize).ToArray();
        tipHeight = tip.localScale.y;

    }

    void Update()
    {
        Draw();
    }

    private void Draw() 
    {
        if (Physics.Raycast(tip.position, transform.up, out touch, tipHeight))
        {
            if (touch.transform.CompareTag("Whiteboard"))
            {
                if (whiteboard == null) 
                {
                    whiteboard = touch.transform.GetComponent<Whiteboard>();
                }
                touchPos = new Vector2(touch.textureCoord.x, touch.textureCoord.y);
            }
        }
    }
}
