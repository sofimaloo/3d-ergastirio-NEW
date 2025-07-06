using UnityEngine;
using TMPro;

public class ShowTooltipOnTrigger : MonoBehaviour
{
    public GameObject tooltipPrefab;        // Το prefab του Tooltip
    public Transform tooltipAnchor;         // Πού θα εμφανίζεται το tooltip
    public string tooltipMessage = "Αυτό είναι το εργαστήριο Α"; // Μήνυμα που θα δείξει

    private GameObject currentTooltip;      // Εσωτερικά, κρατάμε το tooltip για να το σβήσουμε μετά

    // Όταν μπαίνει κάποιος στο collider
    private void OnTriggerEnter(Collider other)
    {
        // Αν αυτός που μπήκε έχει tag "Player"
        if (other.CompareTag("Player") && currentTooltip == null)
        {
            // Βρίσκουμε το Canvas
            Canvas canvas = FindObjectOfType<Canvas>();
            if (canvas == null) return;

            // Δημιουργούμε το tooltip
            currentTooltip = Instantiate(tooltipPrefab, canvas.transform);

            // Βάζουμε το μήνυμα
            var textComp = currentTooltip.GetComponentInChildren<TextMeshProUGUI>();
            if (textComp != null)
                textComp.text = tooltipMessage;

            // Το τοποθετούμε στην οθόνη
            Vector2 screenPos = Camera.main.WorldToScreenPoint(tooltipAnchor.position);
            currentTooltip.GetComponent<RectTransform>().position = screenPos;
        }
    }

    // Όταν φεύγει ο παίκτης από το trigger
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && currentTooltip != null)
        {
            Destroy(currentTooltip); // Σβήνουμε το tooltip
        }
    }
}
