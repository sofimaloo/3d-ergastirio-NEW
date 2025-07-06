using UnityEngine;

public class SpringVisual : MonoBehaviour
{
    public Transform mass;   // � �����
    public Transform anchor; // �� ���� ������ (��� ���� "��������" �� ��������)

    void Update()
    {
        if (mass == null || anchor == null) return;

        // ���������� ��� �� anchor ���� �� �����
        Vector3 direction = mass.position - anchor.position;

        // ���� ��� ���� ��� ���������
        transform.position = anchor.position + direction / 2f;

        // ����������� �� �������� ���� �� ������� ���� �� �����
        transform.up = direction.normalized;

        // ���������� ��� ��������� (���� ����� Y)
        transform.localScale = new Vector3(
            transform.localScale.x,
            direction.magnitude / 2f,
            transform.localScale.z
        );
    }
}
