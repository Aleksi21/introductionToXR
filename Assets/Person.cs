using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Person : MonoBehaviour
{
    public bool toggle = false;
    public InputActionReference action;

    void Start()
    {
        action.action.Enable();
    }

    void Update()
    {
        action.action.performed += teleport=>
        {
            if (toggle == false)
            {
                transform.position = new Vector3(0, 0, 375);
                toggle = true;
            }
            else if (toggle == true)
            {
                transform.position = new Vector3(0, 0, 0);
                toggle = false;
            }
        };
    }
}