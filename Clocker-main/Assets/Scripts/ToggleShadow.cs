using UnityEngine;

public class ToggleShadow : MonoBehaviour
{
    private Renderer objectRenderer;
    private bool isShadowEnabled = true;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        if (objectRenderer == null)
        {
            Debug.LogError("El objeto no tiene un componente Renderer adjunto.");
        }
    }

    private void OnMouseDown()
    {
        ToggleShadowState();
    }

    private void ToggleShadowState()
    {
        isShadowEnabled = !isShadowEnabled;
        objectRenderer.shadowCastingMode = isShadowEnabled ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off;
    }
}