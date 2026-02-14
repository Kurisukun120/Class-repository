using UnityEngine;
using UnityEngine.InputSystem;
public class Birbscript : MonoBehaviour
{   
    public PlayerInput playerInput;
    private InputAction flapAction;
    public float flapPower =6.0f;
    public Rigidbody2D rbody;
    private void Start()
    {
       flapAction = playerInput.actions.FindAction("Flap");
    }
    void Update()
    {
            if (flapAction.WasPressedThisFrame())
            {
               rbody.linearVelocityY = flapPower;
            }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        else if (collision.tag == "Goal")
        {

        }
    }
}
