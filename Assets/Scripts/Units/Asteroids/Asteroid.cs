using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Asteroid : Unit
{
    public void Start()
    {
        Health = 50;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Unit unit = collision.GetComponent<Unit>();

        if(unit && unit is PlayerShip)
        {
            unit.ReceiveDamage(Health);
            Destroy(gameObject);
        }
    }


}
