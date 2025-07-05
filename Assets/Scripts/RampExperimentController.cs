using UnityEngine;
using UnityEngine.UI;  // για το Toggle

public class RampExperimentController : MonoBehaviour
{
    public Toggle rampToggle;  // Αντιστοιχεί στο UI Toggle "Ramp Experiment"

    public void StartRampExperiment()
    {
        // Εδώ βάζεις ό,τι κάνει το πείραμα (π.χ. αρχίζει να τρέχει η μπάλα)
        Debug.Log("Το πείραμα ξεκίνησε!");

        // Και τσεκάρεις το Toggle
        if (rampToggle != null)
        {
            rampToggle.isOn = true;
        }
    }
}
