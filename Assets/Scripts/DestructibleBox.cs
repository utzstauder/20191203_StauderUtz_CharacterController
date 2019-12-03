using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleBox : MonoBehaviour, IDamagable
{
    public int initialHp = 20;
    private int currentHp;

    void Start()
    {
        currentHp = initialHp;
    }

    public void DoDamage(int amount)
    {
        currentHp -= amount;

        if (currentHp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
