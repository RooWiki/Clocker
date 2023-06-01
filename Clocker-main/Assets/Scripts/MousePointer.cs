using UnityEngine;

public class MousePointer : MonoBehaviour
{
    private void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f; // La distancia desde la cámara al puntero del mouse

        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = worldPosition;
    }
}