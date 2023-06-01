using UnityEngine;

public class ChangeSkyColor : MonoBehaviour
{
    public Color targetColor;
    public float colorChangeDuration = 2f;
    public float colorRestoreDelay = 1f;

    private Color originalColor;
    private bool isColorChanging = false;
    private float currentLerpTime = 0f;

    private void Start()
    {
        originalColor = RenderSettings.skybox.GetColor("_Tint");
    }

    private void Update()
    {
        if (isColorChanging)
        {
            currentLerpTime += Time.deltaTime;
            if (currentLerpTime >= colorChangeDuration)
            {
                currentLerpTime = colorChangeDuration;
                isColorChanging = false;
            }

            float t = currentLerpTime / colorChangeDuration;
            Color lerpedColor = Color.Lerp(originalColor, targetColor, t);
            RenderSettings.skybox.SetColor("_Tint", lerpedColor);
        }
    }

    private void OnMouseDown()
    {
        if (!isColorChanging)
        {
            isColorChanging = true;
            currentLerpTime = 0f;
            Invoke("RestoreSkyColor", colorRestoreDelay);
        }
    }

    private void RestoreSkyColor()
    {
        RenderSettings.skybox.SetColor("_Tint", originalColor);
    }
}