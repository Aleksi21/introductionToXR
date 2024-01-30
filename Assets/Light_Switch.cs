using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Light_Switch : MonoBehaviour
{
    public Light lights;
    public InputActionReference action;

    void Start()
    {
        action.action.Enable();
        lights = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        action.action.performed += lights_on =>
        {
            lights.color = Color.cyan;
        };
    }
}
