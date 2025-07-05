using UnityEngine;

public class FreeCamera : MonoBehaviour
{
    public float sensitivity = 2.0f; // ���������������� ����
    public float moveSpeed = 5.0f; // �������� �����������
    public float fastMoveSpeed = 10.0f; // ���������� �������� �����������
    public float smoothTime = 0.12f; // ����� �����������

    private bool isRotating = false;
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    private Vector3 smoothMoveVelocity;

    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // ��������� ������� ������ ������ ����
        {
            isRotating = true;
        }
        if (Input.GetMouseButtonUp(1)) // ��������� ���������� ������ ������ ����
        {
            isRotating = false;
        }

        if (isRotating)
        {
            // �������� ������ �� ���� ����
            float rotateHorizontal = Input.GetAxis("Mouse X") * sensitivity;
            float rotateVertical = Input.GetAxis("Mouse Y") * sensitivity;

            yaw += rotateHorizontal;
            pitch -= rotateVertical;

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }

        // ����������� ������
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float moveUpDown = Input.GetAxis("Jump");

        Vector3 moveDirection = (transform.forward * moveVertical) + (transform.right * moveHorizontal) + (transform.up * moveUpDown);

        float currentMoveSpeed = Input.GetKey(KeyCode.LeftShift) ? fastMoveSpeed : moveSpeed; // �������� ������� Shift
        Vector3 targetVelocity = moveDirection * currentMoveSpeed;

        // ����������� �����������
        transform.position = Vector3.SmoothDamp(transform.position, transform.position + targetVelocity, ref smoothMoveVelocity, smoothTime);
    }
}
