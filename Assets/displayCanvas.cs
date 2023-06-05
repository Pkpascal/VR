using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class displayCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas;
    public bool activate;
    void Start()
    {
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       canvas.SetActive(activate);
    }
}
