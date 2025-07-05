using UnityEngine;

public class PendulumReset : MonoBehaviour
{
    public Transform bob;
    public float startAngle = 20f;

    public void ResetPendulum()
    {
        var rb = bob.GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        bob.localRotation = Quaternion.Euler(0, 0, startAngle);
    }
}
