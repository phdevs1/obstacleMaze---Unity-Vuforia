using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextlevel : MonoBehaviour
{
    public string a = "scene1";
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Model"))
        {
            this.gameObject.SetActive(false);
            Application.LoadLevel(a);
            Debug.Log("colisiononao");
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
