using System.Collections;
using System.Collections.Generic;
using UnityEngine;

sealed class PlayerMiddleShip : PlayerShip
{
    private const float warpLength = 3; // distance of ship's teleport
    private float CurrentWarpTimeClick { get; set; } = 0.2f; //current gap between clicks
    private const float WarpTimeClick = 0.2f; //gap between clicks
    private bool WarpCheckA { get; set; }  = false;
    private bool WarpCheckD { get; set; }  = false;
    private const float warpCooldown = 9f; //cooldown of ship's teleport
    private float CurrentCooldown { get; set; } = 0; //current cooldown of ship's teleport

    private new void Start()
    {
        SpeedTurn = 5.0f;
        MaxHp = 100f;
        base.Start();
        ShipBoundaryRadius = 0.5f;
    }

    private new void Update()
    {
        base.Update();
        MiniWarp();
    }

    //teleport
    private void MiniWarp()
    {
        CurrentCooldown -= Time.deltaTime;
        if (CurrentCooldown <= 0)
        {
            if ((Input.GetKeyDown("a") && WarpCheckA == true) || (Input.GetKeyDown("d") && WarpCheckD == true))
            {
                Vector3 direction = transform.position;
                direction.x += warpLength * (Input.GetAxis("Horizontal") < 0 ? -1 : 1);
                transform.position = direction;
                WarpCheckA = false;
                WarpCheckD = false;
                CurrentCooldown = warpCooldown;
            }
            CurrentWarpTimeClick -= Time.deltaTime;
            if (CurrentWarpTimeClick <= 0)
            {
                WarpCheckA = false;
                WarpCheckD = false;
            }
            if (Input.GetKeyDown("a"))
            {
                CurrentWarpTimeClick = WarpTimeClick;
                WarpCheckA = true;
            }
            if (Input.GetKeyDown("d"))
            {
                CurrentWarpTimeClick = WarpTimeClick;
                WarpCheckD = true;
            }
        }

    }

}
