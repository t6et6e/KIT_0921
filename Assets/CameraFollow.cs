using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;        // ī�޶� ���� ��� (3D ������Ʈ)
    public float smoothSpeed = 5.0f; // ī�޶� �̵��� �ε巴�� �ϱ� ���� �ӵ� ����
    public Vector3 offset = new Vector3(0.0f, 2.0f, -10.0f); // ī�޶�� ��� ������ ������

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset; // ī�޶� ���� ����� ��ġ�� �������� ����

            // �ε巯�� �̵��� ���� Lerp �Լ��� ����Ͽ� ī�޶� ��ġ ����
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;

            // ī�޶� �׻� ����� �ٶ󺸵��� ȸ��
            transform.LookAt(target);
        }
    }
}
