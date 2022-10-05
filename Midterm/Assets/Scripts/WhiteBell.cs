using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBell : MonoBehaviour
{
    public static WhiteBell instance;

    float firingspeed = 10;


    // Start is called before the first frame update
    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSpeed(float initialspeed)
    {
        initialspeed = firingspeed;
    }
}
