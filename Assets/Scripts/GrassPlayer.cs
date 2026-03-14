using UnityEngine;

public class GrassPlayer : Player
{
    public GameObject bulletPrefab;
    protected override void Attack()
    {
     Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        if (collision.tag == "Fire")
        {
            Destroy(gameObject);
        }

    }
}
