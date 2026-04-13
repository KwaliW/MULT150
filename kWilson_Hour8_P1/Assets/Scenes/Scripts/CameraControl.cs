using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Move camera
        transform.Translate(mouseX * moveSpeed * Time.deltaTime,
                             mouseY * moveSpeed * Time.deltaTime,
                             0);
    }
}