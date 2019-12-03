using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowWithDamage : MonoBehaviour, IDamagable
{
    public void DoDamage(int amount)
    {
        transform.localScale *= (1 + (amount/100f));
    }
}
