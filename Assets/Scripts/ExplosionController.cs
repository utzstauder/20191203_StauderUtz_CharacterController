using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    public int damageAmount = 10;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, transform.localScale.x/2f);

            for (int i = 0; i < colliders.Length; i++)
            {
                IDamagable damagable = colliders[i].GetComponent<IDamagable>();

                if (damagable != null)
                {
                    damagable.DoDamage(damageAmount);
                }
            }
            
        }    
    }
}
