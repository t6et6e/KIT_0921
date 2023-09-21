using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;        // 카메라가 따라갈 대상 (3D 오브젝트)
    public float smoothSpeed = 5.0f; // 카메라 이동을 부드럽게 하기 위한 속도 조절
    public Vector3 offset = new Vector3(0.0f, 2.0f, -10.0f); // 카메라와 대상 사이의 오프셋

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset; // 카메라가 따라갈 대상의 위치에 오프셋을 더함

            // 부드러운 이동을 위해 Lerp 함수를 사용하여 카메라 위치 조절
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;

            // 카메라가 항상 대상을 바라보도록 회전
            transform.LookAt(target);
        }
    }
}
