using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float zoomSpeed = 10.0f;   // Speed of zoom
    public float minZoom = 2.0f;      // Minimum zoom level
    public float maxZoom = 10.0f;     // Maximum zoom level
    public float moveSpeed = 5.0f;    // Speed of movement
    public float dragSensitivity = 0.01f; // Sensitivity of dragging

    private Vector3 dragStart;        // Position of cursor when drag starts

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

        // Handle dragging with scroll wheel (mouse button 2)
        if (Input.GetMouseButtonDown(2))
        {
            dragStart = Input.mousePosition;
        }
        if (Input.GetMouseButton(2))
        {
            Vector3 direction = dragStart - Input.mousePosition;
            Camera.main.transform.position += direction * dragSensitivity;
            dragStart = Input.mousePosition;
        }
    }
}
