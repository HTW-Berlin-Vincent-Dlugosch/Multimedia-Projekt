using UnityEngine;
/// <summary>
/// Script <c>PlayerCam</c> is attached to player cam and manages the position according to mouse movement.
/// </summary>
public class PlayerCam : MonoBehaviour

{
    /// <summary>
    /// Sensitivity of xAxis
    /// </summary>
    public float sensX;
    /// <summary>
    /// Sensitivity of yAxis
    /// </summary>
    public float sensY;
    public Transform orientation;
    float rotationX;
    float rotationY;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        rotationX -= mouseY;
        rotationY += mouseX;

        rotationX = Mathf.Clamp(rotationX, -90, 90);
        transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);
        orientation.rotation = Quaternion.Euler(0, rotationY, 0);
    }
}
