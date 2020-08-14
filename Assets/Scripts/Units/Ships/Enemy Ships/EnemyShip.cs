using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class EnemyShip : Ship
{

    protected float SpeedShoot { get; set; } = 1.25f;
    protected float Cooldown { get; set; } = 0;

    private void Start()
    {
        SpeedFly = 1f;
        Bullet = Resources.Load<Bullet>("EnemyBullet");
    }

    private void Update()
    {
        Fly();
        Cooldown -= Time.deltaTime;
        if (Cooldown <= 0)
        {
            Shoot();
            Cooldown = SpeedShoot;
        }
    }

    //полёт вперёд
    private void Fly()
    {
        Vector3 direction = transform.up;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, SpeedFly * Time.deltaTime);
    }

    protected virtual void Shoot()
    {
        Vector3 porition = transform.position;
        porition.y -= 0.7f;
        Bullet newBullet = Instantiate(Bullet, porition, Bullet.transform.rotation);
        newBullet.Direction = newBullet.transform.up;
    }



}
