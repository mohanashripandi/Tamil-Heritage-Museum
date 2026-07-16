
using UnityEngine;

public class FlyCamera : MonoBehaviour
{
    public float moveSpeed = 8f;
    public float lookSpeed = 2f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void Update()
    {
        // Movement
        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward * moveSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.S))
            transform.position -= transform.forward * moveSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            transform.position -= transform.right * moveSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            transform.position += transform.right * moveSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.Q))
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.E))
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;

        // Mouse Look (Right Mouse Button)
        if (Input.GetMouseButton(1))
        {
            float mouseX = Input.GetAxis("Mouse X") * lookSpeed;
            float mouseY = Input.GetAxis("Mouse Y") * lookSpeed;

            transform.Rotate(Vector3.up * mouseX, Space.World);
            transform.Rotate(Vector3.left * mouseY, Space.Self);
        }
    }
}