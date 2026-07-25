using System;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bowing : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private int ForcePower;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        { ShootBall(); }
        if (Keyboard.current.rightArrowKey.isPressed)
            moveright();
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            []Keyboard.current.aKey
    }

    private void ShootBall()
       
{


        rb.AddForce(Vector3.forward * ForcePower, ForceMode.Impulse);
  
}

    private void moveright()
    {
        transform.position += new Vector3(1f, 0f, 0f) * Time.deltaTime;
       
    }

}