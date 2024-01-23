using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class NewInput : MonoBehaviour
{

    private PlayerControls playerControls;
    private Rigidbody rb;

    [SerializeField] float jumpForce = 5f;

    private Transform transformValues;
    private float originalYScale;


    // Start is called before the first frame update
    void Start()
    {
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody>();

        transformValues = GetComponent<Transform>();
        originalYScale = transformValues.localScale.y;
    }



    void OnJump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    }

    void OnPancaking(InputValue input)
    {
        float val = input.Get<float>();

        if(val == 1)
        {
            transformValues.localScale = new Vector3(transformValues.localScale.x * 2f, transformValues.localScale.y / 2f, transformValues.localScale.z * 2f);
        }
        else
        {
            transformValues.localScale = new Vector3(transformValues.localScale.x / 2f, transformValues.localScale.y * 2f, transformValues.localScale.z / 2f);
        }
    }
}
