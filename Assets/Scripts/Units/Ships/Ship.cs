using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Ship : Unit
{
    protected float SpeedFly { get; set; } //standard speed of flight
    protected float MaxHp { get; set; }
    protected Bullet Bullet { get; set; }

}
