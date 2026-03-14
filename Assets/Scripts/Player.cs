using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private PlayerInput playerInput;
    private InputAction action1;
    private InputAction moveAction;

    public float speed = 10.0f;
    private Vector2 direction;
    protected Vector2 lastDirection = Vector2.right;
    private Vector2 valocity;

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        action1 = playerInput.actions.FindAction("Action1");
        moveAction = playerInput.actions.FindAction("Move");
    }

    void Update()
    {
        if (action1.WasPressedThisFrame())
        {
            Attack();
        }
        Movement();
 
    }

    private void Movement()
    {
        direction = moveAction.ReadValue<Vector2>();
        direction.Normalize();

        if (moveAction.IsPressed())
        {
            lastDirection = direction;
        }

        valocity = direction * speed * Time.deltaTime;
        transform.Translate(valocity);
    }

    protected virtual void Attack()
    {

    }
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Pokeball")
        {
            Destroy(gameObject);
        }

    }
}
