using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change_Wall_Dimensions : MonoBehaviour
{
    public GameObject wall;
    public Slider dephtInput;
    public Slider heightInput;
    public Slider widthInput;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canvas.activeSelf == true){
             wall.transform.localScale = new Vector3(widthInput.value,heightInput.value, dephtInput.value);
        }
       
    }
}
