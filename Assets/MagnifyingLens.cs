using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnifyingLens : MonoBehaviour
{
    public Transform magnifyingGlass;
    public Transform magnifyingCamera;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector between the lens and the main camera
        Vector3 vector = magnifyingCamera.InverseTransformPoint(player.position);
        Vector3 target = magnifyingCamera.TransformPoint(-vector);
        magnifyingCamera.LookAt(target, magnifyingGlass.up);
    }
}
