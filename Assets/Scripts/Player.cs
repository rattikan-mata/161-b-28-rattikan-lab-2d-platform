using UnityEngine;

public class Player : Character
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Intialize(100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnHitWith(Enemy enemy)
    {
        TakeDamge(enemy.DamageHit);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Enemy enemy = other.gameObject.GetComponent<Enemy>();

        if (enemy != null)
        {
            OnHitWith(enemy);
        }
    }
}
