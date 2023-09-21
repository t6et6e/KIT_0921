using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // 이동 속도
    public float rotationSpeed = 100.0f; // 회전 속도

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // 플레이어의 입력을 받음
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // 이동 벡터 계산
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * moveSpeed * Time.deltaTime;

        // Rigidbody를 사용하여 캐릭터 이동
        rb.MovePosition(transform.position + movement);

        // 마우스 입력을 받아 캐릭터 회전
        float mouseX = Input.GetAxis("Mouse X");
        Vector3 rotation = new Vector3(0, mouseX * rotationSpeed * Time.deltaTime, 0);
        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation));
    }
}
