using UnityEngine;

public class ToggleShadowWithSound : MonoBehaviour
{
    private Renderer objectRenderer;
    private bool isShadowEnabled = true;
    public AudioClip clickSound;

    private AudioSource audioSource;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        if (objectRenderer == null)
        {
            Debug.LogError("El objeto no tiene un componente Renderer adjunto.");
        }

        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    private void OnMouseDown()
    {
        ToggleShadowState();
        PlayClickSound();
    }

    private void ToggleShadowState()
    {
        isShadowEnabled = !isShadowEnabled;
        objectRenderer.shadowCastingMode = isShadowEnabled ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off;
    }

    private void PlayClickSound()
    {
        if (clickSound != null)
        {
            audioSource.PlayOneShot(clickSound);
        }
    }
}