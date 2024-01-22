using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class NewInput : MonoBehaviour
{

    private PlayerControls playerControls;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody>();
    }

    public void OnJump()
    {
        Debug.Log("Jump!");
    }

    public void OnPancaking(InputValue input)
    {
        float val = input.Get<float>();

        Debug.Log(val);
    }
}
