using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerControl : MonoBehaviour
{
    public static PlayerControl instance;

    public BasicControl input;
    Vector2 move;
    private float speed = 0.03f;
    public Camera playercam;
    Vector3 cameraRotation;


    public GameObject bullets;
    public Transform bulletPos;

    Rigidbody rb;

    // Start is called before the first frame update
    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
        input = InputController.controller.input;


        input.Bee.Shoot.performed += cntxt => Shoot();

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed, Space.Self);
        
    }

    public void Shoot()
    {
        Rigidbody bulletRb = Instantiate(bullets, bulletPos.position, Quaternion.identity).GetComponent<Rigidbody>();
        bulletRb.AddForce(transform.up * 35f, ForceMode.Impulse);
        
    }
}
