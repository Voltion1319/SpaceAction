using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Bullet : MonoBehaviour
{
    protected Vector3 direction;
    public Vector3 Direction { set { direction = value; } }
    protected int damage = 10;
    public int Damage
    {
        get
        {
            return damage;
        }

        protected set
        {
            damage = value;
        }
    }

    protected float Speed { get; set; }

    protected void Start()
    {
        Destroy(gameObject, 1.5f);
    }

    protected void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,transform.position + direction, Speed*Time.deltaTime);
    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        Unit unit = collision.GetComponent<Unit>();

        if (unit)
        {
            unit.ReceiveDamage(Damage);            
        }
        Destroy(gameObject);
    }

}
