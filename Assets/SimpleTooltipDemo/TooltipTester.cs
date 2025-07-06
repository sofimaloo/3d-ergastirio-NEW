using UnityEngine;
using TMPro;

public class TooltipTester : MonoBehaviour
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

        TextMeshProUGUI textComp = tooltip.GetComponentInChildren<TextMeshProUGUI>();
        if (textComp != null)
            textComp.text = "Αυτό είναι ένα Tooltip!";

        tooltip.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
    }
}
