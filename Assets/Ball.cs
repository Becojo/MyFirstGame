using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Ball : MonoBehaviour
{
    public enum State {
        PickAngle,
        PickForce,
        Shooting,
        Dead
    }

    public State state = State.PickAngle;

    public SliderSin angleSlider;
    public SliderSin forceSlider;

    public Camera ballCamera;
    public Camera mainCamera;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;

        angleSlider.moving = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space)) {
            switch(state) {
                case State.PickAngle:
                    state = State.PickForce;

                    angleSlider.moving = false;
                    forceSlider.moving = true;
                    break;

                case State.PickForce:
                    state = State.Shooting;

                    forceSlider.moving = false;

                    rb.useGravity = true;

                    rb.AddForce((angleSlider.slider.value - 0.5f) * 0.005f, 0, forceSlider.slider.value / 100.0f, ForceMode.Impulse);

                    mainCamera.enabled = false;
                    ballCamera.enabled = true;

                    break;
            }
        }

        
    }
}
