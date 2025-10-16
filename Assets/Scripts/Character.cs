using UnityEngine;

public abstract class Character : MonoBehaviour
{
    private int health;
    public int Health
    {
        get { return health; }
        set { health = (value < 0) ? 0 : value; }
    }

    protected Animator anim;
    protected Rigidbody2D rb;

    public void TakeDamge(int damage)
    { 
        Health -= damage; 
        Debug.Log($"{this.name} took damage {damage}. Current Health: {Health}");
    }

    public bool IsDead()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            return true;
        }
        else { return false; }
    }
}
