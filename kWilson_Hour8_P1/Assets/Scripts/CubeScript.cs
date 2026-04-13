using UnityEngine;

public class CubeScript : MonoBehaviour
{
    void Update()
    {
        // Move the cube slightly every frame
        transform.Translate(0.05f, 0f, 0f);

        // Rotate the cube every frame
        transform.Rotate(0f, 0f, 1f);

        // Set the cube's scale
        transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
}