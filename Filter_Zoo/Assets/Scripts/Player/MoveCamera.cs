using UnityEngine;
/// <summary>
/// Script <c>MoveCamera</c> Moves player cam in correct position for first person view
/// </summary>
public class MoveCamera : MonoBehaviour
{
    /// <summary>
    /// Camera Position
    /// </summary>
    public Transform cameraPosition;
    void Update()
    {
        transform.position = cameraPosition.position;
    }
}