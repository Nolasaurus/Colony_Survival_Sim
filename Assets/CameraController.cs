using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float zoomSpeed = 10.0f; // Speed of zoom
    public float minZoom = 2.0f;    // Minimum zoom level
    public float maxZoom = 10.0f;   // Maximum zoom level

    public float moveSpeed = 5.0f;  // Speed of movement

    void Update()
    {
        // Handle zooming with scroll wheel
        float zoom = Input.GetAxis("Mouse ScrollWheel") * zoomSpeed * Time.deltaTime;
        float newZoom = Mathf.Clamp(Camera.main.orthographicSize - zoom, minZoom, maxZoom);
        Camera.main.orthographicSize = newZoom;

        // Handle movement with WASD keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(horizontalInput, verticalInput, 0) * moveSpeed * Time.deltaTime;
        transform.position += move;
    }
}
