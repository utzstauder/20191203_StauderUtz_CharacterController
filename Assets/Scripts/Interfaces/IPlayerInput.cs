using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerInput
{
    float HInput { get; }
    float VInput { get; }

    event System.Action OnJumpPressed;
}
