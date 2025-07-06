using UnityEngine;

public class PendulumController : MonoBehaviour
{
    Rigidbody rb;
    public float pushForce = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }

    public void PushPendulum()
    {
        // Push the pendulum sideways
        rb.AddForce(new Vector3(0f, 0f, pushForce), ForceMode.Impulse);

    }
}
