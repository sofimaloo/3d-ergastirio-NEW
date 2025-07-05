using UnityEngine;
using TMPro;

public class PendulumMonitor : MonoBehaviour
{
    public HingeJoint hinge;
    public float length = 1.0f;
    public TMP_Text theoText;
    public TMP_Text measText;

    float lastCrossTime;
    bool lastSide;

    void Start()
    {
        float g = Physics.gravity.magnitude;
        float Tth = 2 * Mathf.PI * Mathf.Sqrt(length / g);
        theoText.text = $"Tₜₕ = {Tth:F2} s";
        lastCrossTime = Time.time;
        lastSide = hinge.angle > 0;
    }

    void Update()
    {
        bool nowSide = hinge.angle > 0;
        if (nowSide != lastSide)
        {
            float period = Time.time - lastCrossTime;
            measText.text = $"Tₘₑₐₛ = {period:F2} s";
            lastCrossTime = Time.time;
            lastSide = nowSide;
        }
    }
}
