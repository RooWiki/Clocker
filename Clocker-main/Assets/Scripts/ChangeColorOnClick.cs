using UnityEngine;

public class ChangeColorOnClick : MonoBehaviour
{
    public Color targetColor;

    private Color originalColor;
    private Renderer objectRenderer;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalColor = objectRenderer.material.color;
    }

    private void OnMouseDown()
    {
        objectRenderer.material.color = targetColor;
    }

    private void OnMouseUp()
    {
        objectRenderer.material.color = originalColor;
    }
}