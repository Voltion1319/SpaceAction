using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

sealed class PlayerBigShip : PlayerShip
{
    private new void Start()
    {
        SpeedTurn = 3.0f;
        MaxHp = 150f;
        base.Start();
        ShipBoundaryRadius = 0.5f;
    }

}

