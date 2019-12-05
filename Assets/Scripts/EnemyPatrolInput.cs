using System;
using UnityEngine;

public class EnemyPatrolInput : MonoBehaviour, IPlayerInput
{
    private float hInput, vInput;

    public float HInput { get { return hInput; } }
    public float VInput { get { return vInput; } }

    private float timer = 0;
    public float maxTime = 5f;

    public event Action OnJumpPressed;

    private void Start()
    {
        hInput = 1;
    }

    private void Update()
    {
        if (timer > maxTime)
        {
            timer = 0;
            hInput *= -1;
        }
        timer += Time.deltaTime;
    }
}
