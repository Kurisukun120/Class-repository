using UnityEngine;

public class WaterPlayer : Player
{
    protected override void Attack()
    {

    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        if (collision.tag == "Grass")
        {
            Destroy(gameObject);
        }

    }
}
