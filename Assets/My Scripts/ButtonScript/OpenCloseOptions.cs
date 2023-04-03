using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseOptions : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shipping;
    public GameObject payment;

    public void Start()
    {   
        shipping.transform.localScale = Vector2.zero;
        payment.transform.localScale = Vector2.zero;
    }

    public void OpenShipping() {
        shipping.LeanScale(Vector2.one, 0.3f);
        payment.transform.localScale = Vector2.zero;
    }

    public void OpenPayment() {
        payment.LeanScale(Vector2.one, 0.3f);
        shipping.transform.localScale = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
