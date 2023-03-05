using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resize : MonoBehaviour
{
    public OVRInput.Controller LController;
    public OVRInput.Controller RController;
    public string buttonSelect;
    public string buttonDrag;
    public float selectRadius;
    public LayerMask selectMask;

    private GameObject selectedObject;
    private bool selecting;
    private bool moving;
    private Vector3 currentPos;
    private Vector3 newPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // "A" button press
        if (OVRInput.GetDown(OVRInput.Button.One)) {
            newPos = OVRInput.GetLocalControllerPosition(RController);
        }

        // "X" button press
        if (!selecting && OVRInput.GetDown(OVRInput.Button.Three)) 
        {            
            SelectObject();
        }
        
        // "X" button release
        if (selecting && !OVRInput.GetDown(OVRInput.Button.Three)) 
        {
            UnselectObject();
        }

        // "A" button release
        if (moving && !OVRInput.GetDown(OVRInput.Button.One)) {
            moving = false;
        }
    }

    void SelectObject() 
    {
        selecting = true;

        RaycastHit[] hits;

        // only react for objects in the correct layer(s)
        hits = Physics.SphereCastAll(transform.position, selectRadius, transform.forward, 0f, selectMask);

        if (!moving && Input.GetAxis(buttonDrag) == 1) {
            moving = true;
            currentPos = newPos;
        }

        if (hits.Length > 0) 
        {
            int closestHit = 0;

            for (int i = 0; i < hits.Length; i++) 
            {
                if ((hits[i]).distance < hits[closestHit].distance) 
                {
                    closestHit = i;
                }
            }

            selectedObject = hits[closestHit].transform.gameObject;
            //selectedObject.transform.localeScale += scaleChange;
            //selectedObject.GetComponent<Rigidbody>().isKinematic = true;
            //selectedObject.transform.position = transform.position;
            //selectedObject.transform.parent = transform;

            if (moving) {
                selectedObject.transform.localScale += newPos - currentPos; 
            }
        }
    }

    void UnselectObject() 
    {
        selecting = false;
        moving = false;

        if (selectedObject != null) 
        {
            selectedObject.transform.parent = null;
            //selectedObject.GetComponent<Rigidbody>().isKinematic = false;

            //selectedObject.GetComponent<Rigidbody>().velocity = OVRInput.GetLocalLControllerVelocity(LController);
            //selectedObject.GetComponent<Rigidbody>().angularVelocity = OVRInput.GetLocalLControllerAngularVelocity(LController);

            selectedObject = null;
        }
    }
}
