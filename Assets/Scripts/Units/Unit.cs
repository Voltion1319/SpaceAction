using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Unit : MonoBehaviour
{

    protected float Health { get; set; }

	public virtual void ReceiveDamage(float damage)
    {
        Health -= damage;
        if (Health<=0)
        {
            Health = 0;
            Die();
        }
    }

    protected virtual void Die()
    {
        Destroy(gameObject);
    }
}
