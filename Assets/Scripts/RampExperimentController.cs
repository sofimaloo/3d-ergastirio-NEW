using UnityEngine;
using UnityEngine.UI;  // ��� �� Toggle

public class RampExperimentController : MonoBehaviour
{
    public Toggle rampToggle;  // ����������� ��� UI Toggle "Ramp Experiment"

    public void StartRampExperiment()
    {
        // ��� ������ �,�� ����� �� ������� (�.�. ������� �� ������ � �����)
        Debug.Log("�� ������� ��������!");

        // ��� ��������� �� Toggle
        if (rampToggle != null)
        {
            rampToggle.isOn = true;
        }
    }
}
