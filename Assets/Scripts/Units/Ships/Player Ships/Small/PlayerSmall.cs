using System.Collections;
using System.Collections.Generic;
using UnityEngine;

sealed class PlayerSmall : PlayerShip
{
    private new void Start()
    {
        SpeedTurn = 7.0f;
        MaxHp = 50f;
        base.Start();
        ShipBoundaryRadius = 0.33f;
    }
}
