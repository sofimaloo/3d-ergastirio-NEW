using UnityEngine;

public class TooltipTester1 : MonoBehaviour
{
    public GameObject tooltipPrefab;

    void Start()
    {
        Canvas canvas = FindObjectOfType<Canvas>();
        if (canvas == null)
        {
            Debug.LogError("Canvas not found!");
            return;
        }

        GameObject tooltip = Instantiate(tooltipPrefab, canvas.transform);
        
        // Θέτει το κείμενο στο πρώτο TMP στοιχείο που βρει
        TMPro.TextMeshProUGUI textComp = tooltip.GetComponentInChildren<TMPro.TextMeshProUGUI>();
        if (textComp != null)
            textComp.text = "Αυτό είναι ένα Tooltip!";

        // Τοποθέτηση στο κέντρο
        tooltip.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
    }
}
