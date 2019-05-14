using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class click : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Model"))
        {
            Debug.Log("colisiononao");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    public void OnButtonPressed (VirtualButtonBehaviour vd)
    {

    }
    

}
