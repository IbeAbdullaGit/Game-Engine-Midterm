using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    public BasicControl input;

    public static InputController controller;


    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }

    // Start is called before the first frame update
    void Awake()
    {
        if(controller == null)
        {
            controller = this;
        }

        input = new BasicControl();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
