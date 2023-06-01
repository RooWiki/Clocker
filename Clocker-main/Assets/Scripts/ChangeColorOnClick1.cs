using UnityEngine;

public class ChangeColorOnClick1 : MonoBehaviour
{
    public Color targetColor;
    private Color originalColor;
    private Renderer objectRenderer;
    private bool isClicked;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalColor = objectRenderer.material.color;
        isClicked = false;
    }

    private void OnMouseDown()
    {
        if (!isClicked)
        {
            objectRenderer.material.color = targetColor;
            isClicked = true;
        }
        else
        {
            objectRenderer.material.color = originalColor;
            isClicked = false;
        }
    }
}