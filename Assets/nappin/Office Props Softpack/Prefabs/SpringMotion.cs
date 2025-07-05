using UnityEngine;

public class SpringMotion : MonoBehaviour
{
    public Transform mass;
    public Transform spring;
    public float amplitude = 1f;       // Πλάτος ταλάντωσης
    public float frequency = 1f;       // Συχνότητα
    public float restLength = 2f;      // Μήκος ελατηρίου σε ηρεμία

    private Vector3 initialMassPos;
    private Vector3 springTop;

    void Start()
    {
        initialMassPos = mass.localPosition;
        springTop = spring.localPosition;
    }

    void Update()
    {
        float yOffset = Mathf.Sin(Time.time * frequency * 2 * Mathf.PI) * amplitude;
        Vector3 newMassPos = initialMassPos + new Vector3(0, -yOffset, 0);
        mass.localPosition = newMassPos;

        float newSpringLength = restLength + yOffset;
        spring.localScale = new Vector3(spring.localScale.x, newSpringLength / 2f, spring.localScale.z);
        spring.localPosition = new Vector3(0, newMassPos.y / 2f, 0);
    }
}
