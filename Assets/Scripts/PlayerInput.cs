﻿using UnityEngine;

public class PlayerInput : MonoBehaviour, IPlayerInput
{
    private float hInput, vInput;

    public float HInput { get { return hInput; } }
    public float VInput { get { return vInput; } }

    private void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");
        vInput = Input.GetAxisRaw("Vertical");
    }
}