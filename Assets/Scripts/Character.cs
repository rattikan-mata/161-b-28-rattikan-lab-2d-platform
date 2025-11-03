using UnityEngine;
using UnityEngine.UI;

public abstract class Character : MonoBehaviour
{
    [SerializeField]
    private Slider sliderHp;

    private float maxHp;

    private int health;
    public int Health
    {
        get { return health; }
        set { health = (value < 0) ? 0 : value; UpdateHealthBar(); }
    }

    protected Animator anim;
    protected Rigidbody2D rb;

    public void Intialize(int startHealth)
    {
        maxHp = startHealth;
        Health = startHealth;
        Debug.Log($"{this.name} is initialized Health : {this.Health}");

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void UpdateHealthBar()
    {
        if (sliderHp != null && maxHp > 0)
        {
            sliderHp.value = (float)health / maxHp;
        }
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"{this.name} took damage {damage}. Current Health: {Health}");

        IsDead();
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
