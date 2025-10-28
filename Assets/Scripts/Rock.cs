using UnityEngine;

public class Rock : Weapon
{
    public Rigidbody2D rb2d;
    public Vector2 force;

    public override void Move()
    {
        rb2d.AddForce(force);
    }

    public override void OnHitWith(Character obj)
    {
        if (obj is Player)
            obj.TakeDamage(this.damage);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        damage = 40;
        force = new Vector2(GetShootDirection() * 90, 400);
        Move();
    }
}
