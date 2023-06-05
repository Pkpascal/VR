using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class update_SliderValue_Height : MonoBehaviour
{
  public GameObject wall;
    public Slider thisSlider;

    // Start is called before the first frame update
    void Start()
    {
        thisSlider.value = wall.transform.localScale.y;
    }
}
