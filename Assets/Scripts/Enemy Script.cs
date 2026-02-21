using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private float speed = 5.0f;

    void Start()
    {
        Destroy(gameObject, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
