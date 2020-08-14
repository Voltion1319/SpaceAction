using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

abstract class PlayerShip : Ship
{
    protected float SpeedTurn { get; set; }
    protected float Nitro { get; set; } = 2.5f; //ship's acceleration 
    protected float ShipBoundaryRadius { get; set; }
    protected float MapWidth { get; set; } = 10f;
    protected HealthBar Hp { get; set; }
    protected float CurrentSpeed { get; set; }

    protected void Start()
    {
        SpeedFly = 1f;
        Hp = GameObject.FindGameObjectWithTag("HP").GetComponent<HealthBar>();
        CurrentSpeed = SpeedFly;
        Health = MaxHp;
        Bullet = Resources.Load<Bullet>("Bullet");
    }

    protected void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            Turn();                     
        }
        if (Input.GetButtonDown("Vertical") && Input.GetAxis("Vertical")>0)
        {
            Boost();
        }
        if (Input.GetButtonUp("Vertical"))
        {
            CurrentSpeed = SpeedFly;
        }
        if (Input.GetButtonDown("Fire1"))
            Shoot();
        Fly();
    }
    //ship's acceleration 
    private void Boost()
    {
        CurrentSpeed = SpeedFly + Nitro;
    }

    private void Shoot()
    {
        Vector3 porition = transform.position;
        porition.y += 0.7f;
        Bullet newBullet = Instantiate(Bullet,porition ,Bullet.transform.rotation);
        newBullet.Direction = newBullet.transform.up;
    }

    private void Turn()
    {
        Vector3 direction = transform.right * Input.GetAxis("Horizontal");
        var pos = Vector3.MoveTowards(transform.position, transform.position + direction, SpeedTurn * Time.deltaTime);

        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;

        if (pos.x + ShipBoundaryRadius > widthOrtho)
            pos.x = widthOrtho - ShipBoundaryRadius;
        if (pos.x - ShipBoundaryRadius < -widthOrtho)
            pos.x = -widthOrtho + ShipBoundaryRadius;

        transform.position = pos;
    }
    //standart flight
    private void Fly()
    {
        Vector3 direction = transform.up;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, CurrentSpeed * Time.deltaTime);
    }
    //taking damage and displaying on hp bar
    public override void ReceiveDamage(float damage)
    {
        base.ReceiveDamage(damage);
        Hp.Changehp(Health/MaxHp);
    }

}
