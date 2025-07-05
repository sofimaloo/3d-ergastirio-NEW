using UnityEngine;
using UnityEditor;

public class FixMaterialsTool : EditorWindow
{
    private Material fixMaterial;

    [MenuItem("Tools/Fix Fuchsia Materials")]
    public static void ShowWindow()
    {
        GetWindow<FixMaterialsTool>("Fix Materials");
    }

    void OnGUI()
    {
        GUILayout.Label("Αντικατάσταση όλων των φούξια/προβληματικών υλικών", EditorStyles.boldLabel);
        fixMaterial = (Material)EditorGUILayout.ObjectField("Υλικό αντικατάστασης", fixMaterial, typeof(Material), false);

        if (GUILayout.Button("Εφαρμογή σε όλη τη σκηνή"))
        {
            FixAllMaterials();
        }
    }

    void FixAllMaterials()
    {
        if (fixMaterial == null)
        {
            Debug.LogError("⚠️ Δεν έχεις ορίσει υλικό αντικατάστασης!");
            return;
        }

        int fixedCount = 0;

        foreach (GameObject go in FindObjectsOfType<GameObject>())
        {
            MeshRenderer renderer = go.GetComponent<MeshRenderer>();
            if (renderer != null)
            {
                Material[] materials = renderer.sharedMaterials;
                bool hasNone = false;

                foreach (var mat in materials)
                {
                    if (mat == null)
                    {
                        hasNone = true;
                        break;
                    }
                }

                if (hasNone || materials.Length > 1)
                {
                    renderer.sharedMaterials = new Material[] { fixMaterial };
                    fixedCount++;
                }
            }
        }

        Debug.Log($"✅ Αντικαταστάθηκαν υλικά σε {fixedCount} αντικείμενα!");
    }
}
