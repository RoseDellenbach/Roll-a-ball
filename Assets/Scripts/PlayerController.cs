using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;

    private Rigidbody rb;
    private float movementX;
    private float movementY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movmentValue)
    {
        Vector2 movmentVector = movmentValue.Get<Vector2>();

        movementX = movmentVector.x;
        movementY = movmentVector.y;
    }

    void FixedUpdate()
    {
        Vector3 movment = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movment * speed);
    }
}
