using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    public GameObject linterna;
    public bool laTengo;

    // Start is called before the first frame update
    void Start()
    {
        laTengo = false;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        laTengo = true;
        linterna.SetActive(false);
        Debug.Log("tengo la linterna");
    }
}
