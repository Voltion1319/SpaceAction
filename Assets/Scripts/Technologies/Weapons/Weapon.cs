using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Weapon : Technology
{
    protected Vector3 pos;
    protected Bullet bullet;
    protected float shootingSpeed;
    //maybe
    protected float range;
    protected float accuracy;

    protected void Shoot()
    {

    }
}
