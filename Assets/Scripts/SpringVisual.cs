using UnityEngine;

public class SpringVisual : MonoBehaviour
{
    public Transform mass;   // Η μπάλα
    public Transform anchor; // Το πάνω σημείο (από όπου "κρέμεται" το ελατήριο)

    void Update()
    {
        if (mass == null || anchor == null) return;

        // Κατεύθυνση από το anchor προς τη μπάλα
        Vector3 direction = mass.position - anchor.position;

        // Θέση στο μέσο του ελατηρίου
        transform.position = anchor.position + direction / 2f;

        // Περιστρέφει το ελατήριο ώστε να δείχνει προς τη μπάλα
        transform.up = direction.normalized;

        // Επιμήκυνση του ελατηρίου (στον άξονα Y)
        transform.localScale = new Vector3(
            transform.localScale.x,
            direction.magnitude / 2f,
            transform.localScale.z
        );
    }
}
