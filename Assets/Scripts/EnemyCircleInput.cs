using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCircleInput : MonoBehaviour, IPlayerInput
{
    private float hInput, vInput;
    private float direction = 1;
    private float timer = 0;

    public float HInput { get { return hInput; } }

    public float VInput { get { return vInput; } }

    public event Action OnJumpPressed;

    void Update()
    {
        hInput = Mathf.Sin(timer);
        vInput = Mathf.Cos(timer) * direction;

        if (timer > 2 * Mathf.PI)
        {
            timer -= 2 * Mathf.PI;
            direction *= -1;
        }

        timer += Time.deltaTime;
    }
}
