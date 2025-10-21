using UnityEngine;

public class Ant : Enemy
{
    [SerializeField] Vector2 velocity;
    public Transform[] MovePoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Intialize(20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Behavior()
    {
        throw new System.NotImplementedException();
    }
}
