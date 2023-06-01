using UnityEngine;

public class DirectionalLightController : MonoBehaviour
{
    private Transform center;

    private void Start()
    {
        // Encuentra el objeto con la etiqueta "Center" en la escena
        center = GameObject.FindGameObjectWithTag("Center").transform;

        if (center == null)
        {
            Debug.LogError("No se encontró el objeto con la etiqueta 'Center'. Asegúrate de etiquetar un objeto con 'Center' en la escena.");
        }
    }

    private void Update()
    {
        // Apunta la luz direccional hacia el centro de la escena
        if (center != null)
        {
            transform.LookAt(center.position);
        }
    }
}

