using UnityEngine;
using UnityEngine.UI;

public class SpringExperimentController : MonoBehaviour
{
    public Rigidbody mass;
    public Vector3 nudgeVelocity = new Vector3(0, -1f, 0);

    public Toggle springToggle; // ➕ Νέο πεδίο για το UI

    public void StartSpringExperiment()
    {
        if (mass != null)
        {
            mass.velocity = nudgeVelocity;
            Debug.Log("Ξεκίνησε το πείραμα ελατηρίου!");
        }

        // ➕ Τικάρισμα του toggle όταν ξεκινάει
        if (springToggle != null)
        {
            springToggle.isOn = true;
        }
    }
}
