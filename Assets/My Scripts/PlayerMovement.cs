using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("moveHorizontal");
        float moveVertical = Input.GetAxis("moveVertical");
        float rotateHorizontal = Input.GetAxis("rotateHorizontal");
        float rotateVertical = Input.GetAxis("rotateVertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement);
        transform.Rotate(new Vector3(-rotateVertical, rotateHorizontal, 0.0f));
    }
}
