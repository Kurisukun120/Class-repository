using UnityEngine;

public class FirePlayer : Player
{
    public Bullet bulletPrefab;
    protected override void Attack()
    {
        Bullet newBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        newBullet.SetDirection(lastDirection);
    }
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        if (collision.tag == "Water")
        {
            Destroy(gameObject);
        }
    }
}
