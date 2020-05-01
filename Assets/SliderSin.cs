using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

public class SliderSin : MonoBehaviour
{
    public Slider slider;
    public bool moving = false;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(moving) {
            slider.value = (float)Math.Pow(Math.Cos(Time.realtimeSinceStartup / 1.0f), 4);
        }
    }
}
