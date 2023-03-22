using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFollowLate : MonoBehaviour
{

    private Vector2 _velocity = Vector2.zero;
    private Vector2 _lastPos = Vector2.zero;

    private RectTransform _rect;

    public Transform Target;
    public float Friction = 0.15f;
    public float Spring = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        _rect = GetComponent<RectTransform>();    
    }

    // Update is called once per frame
    void Update()
    {
        _velocity += ((Vector2) Target.localPosition - _lastPos) * Friction;
        _velocity *= Spring;
        _lastPos = (Vector2) Target.localPosition;

        _rect.localPosition = _velocity;
    }
}
