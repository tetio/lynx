using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterKeyboardControl : CharacterBaseControl
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateDirection();
        UpdateAction();

    }

    private void UpdateAction()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnActionPressed();
        }
    }

    void UpdateDirection()
    {
        int leftDir = 0;
        int rightDir = 0;
        int upDir = 0;
        int downDir = 0;
        if (Input.GetKey(KeyCode.W))
        { 
            upDir = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            downDir = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            leftDir = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rightDir = 1;
        } 
        SetDirection(new Vector2(leftDir + rightDir, upDir + downDir));

    }
}